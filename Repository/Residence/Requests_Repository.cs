using PortalAPI.Models;
using PortalAPI.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;

namespace PortalAPI.Repository.Residence
{
    public class Requests_Repository : Requests_Interface
    {
        private readonly ResidenceContext ResidenceContext;

        public Requests_Repository(ResidenceContext context)
        {
            ResidenceContext = context;
        }

        public async Task<VM_Resault> Create(Requests request, string hrCode)
        {
            if (!ResidenceContext.Projects.Any(p => p.ID == request.Proj_ID))
                return new VM_Resault { message = "Project not found", code = 404, error = true };

            if (!ResidenceContext.Buildings.Any(b => b.ID == request.Buildings_ID))
                return new VM_Resault { message = "Building not found", code = 404, error = true };

            if (!ResidenceContext.Units.Any(u => u.ID == request.Unit_ID))
                return new VM_Resault { message = "Unit not found", code = 404, error = true };

            if (!ResidenceContext.PaymentPlans.Any(p => p.Id == request.PaymentPlan_ID))
                return new VM_Resault { message = "Payment plan not found", code = 404, error = true };

            // select unit where unit id as per requested and status is pending/progress
            var requestWithUnitExists = ResidenceContext.Requests
                .Any
                (
                    r => r.Unit_ID == request.Unit_ID 
                    && 
                    (r.Status == RequestsStatus.Pending || r.Status == RequestsStatus.InProgress)
                ); 

            if (requestWithUnitExists)
                return new VM_Resault { message = "Unit already taken", code = 409, error = true }; // Conflict on trying to select same unit


            var unitHasPlan = ResidenceContext.UnitPaymentPlan.Any(p => p.Unit_ID == request.Unit_ID && p.PaymentPlan_ID == request.PaymentPlan_ID);

            if(!unitHasPlan)
                return new VM_Resault { message = "Unit does not have selected plan", code = 409, error = true }; 

            request.In_Date = DateTime.Now;
            request.Hrcode = hrCode;
            request.In_User = hrCode;
            request.Status = RequestsStatus.Pending;    // Over write the value if client sets it up

            var newEntity = (await ResidenceContext.Requests.AddAsync(request)).Entity;
            await ResidenceContext.SaveChangesAsync();

            return new VM_Resault
            {
                message = "Request created successfully",
                code = 201,
                error = false,
                data = new List<object> { newEntity }
            };
        }

        public async Task<VM_Resault> Delete(List<int> ids)
        {
            var requests = await ResidenceContext.Requests
                .Where(r => ids.Contains(r.Id))
                .ToListAsync();

            foreach(var request in requests)
                request.IsActive = false;
            
            //ResidenceContext.Requests.RemoveRange(requests);
            await ResidenceContext.SaveChangesAsync();

            return new VM_Resault
            {
                message = "Requests deleted successfully",
                code = 204,
                error = false
            };
        }

        public async Task<VM_Resault> GetAll()
        {
            var requests = await ResidenceContext.Requests
                .Where(r => r.IsActive == true)
                .Include(r => r.Proj)
                .Include(r => r.Buildings)
                .Include(r => r.Unit)
                .Select(r => new
                {
                    r.Id,
                    r.Description,
                    r.Status,
                    r.Hrcode,
                    r.Proj_ID,
                    ProjName = r.Proj.Name,
                    r.Buildings_ID,
                    BuildingName = r.Buildings.Name,
                    r.UnitId,
                    UnitNo = r.Unit.No,
                    r.PaymentPlanId,
                    r.SharingUsers
                })
                
                .ToListAsync();

            return new VM_Resault
            {
                message = "Success",
                code = 200,
                error = false,
                data = requests.Cast<object>().ToList()
            };
        }

        public async Task<VM_Resault> PatchStatus(int id, int status, string hrCode)
        {
            var element = ResidenceContext.Requests.FirstOrDefault(r => r.Id == id);
            if(element == null)
            {
                return new VM_Resault
                {
                    message = "Request not found",
                    code = 404,
                    error = true
                };
            }

            element.Status = status;
            element.Up_Date = DateTime.Now;
            element.Up_User = hrCode;

            await ResidenceContext.SaveChangesAsync();

            return new VM_Resault
            {
                message = "Status updated",
                code = 204,
                error = true
            };
        }

        // Busniess requirment needs this?
        //public async Task<VM_Resault> Update(int id, Requests requestUpdate, string hrCode)
        //{
        //    var request = await ResidenceContext.Requests.FirstOrDefaultAsync(r => r.Id == id);
        //    if (request == null)
        //    {
        //        return new VM_Resault { message = "Request not found", code = 404, error = true };
        //    }

        //    // Re-check related entities
        //    if (!ResidenceContext.Projects.Any(p => p.Id == requestUpdate.ProjId))
        //        return new VM_Resault { message = "Project not found", code = 404, error = true };

        //    if (!ResidenceContext.Buildings.Any(b => b.Id == requestUpdate.BuildingsId))
        //        return new VM_Resault { message = "Building not found", code = 404, error = true };

        //    if (!ResidenceContext.Units.Any(u => u.Id == requestUpdate.UnitId))
        //        return new VM_Resault { message = "Unit not found", code = 404, error = true };

        //    if (!ResidenceContext.PaymentPlans.Any(p => p.Id == requestUpdate.PaymentPlanId))
        //        return new VM_Resault { message = "Payment plan not found", code = 404, error = true };

        //    // Update fields
        //    request.Hrcode = requestUpdate.Hrcode;
        //    request.ProjId = requestUpdate.ProjId;
        //    request.BuildingsId = requestUpdate.BuildingsId;
        //    request.UnitId = requestUpdate.UnitId;
        //    request.Description = requestUpdate.Description;
        //    request.PaymentPlanId = requestUpdate.PaymentPlanId;
        //    request.SharingUsers = requestUpdate.SharingUsers;
        //    request.Status = requestUpdate.Status;
        //    request.UpDate = DateTime.Now;
        //    request.UpUser = hrCode;

        //    ResidenceContext.Requests.Update(request);
        //    await ResidenceContext.SaveChangesAsync();

        //    return new VM_Resault
        //    {
        //        message = "Request updated successfully",
        //        code = 200,
        //        error = false,
        //        data = new List<object> { request }
        //    };
        //}

        public async Task<VM_Resault> GetByUser(string hrCode)
        {
            var requests = await ResidenceContext.Requests
                .Where(r => r.Hrcode == hrCode && r.IsActive == true)
                .Include(r => r.Proj)
                .Include(r => r.Buildings)
                .Include(r => r.Unit)
                .Select(r => new
                {
                    r.Id,
                    r.Description,
                    r.Status,
                    r.Hrcode,
                    r.Proj_ID,
                    ProjName = r.Proj.Name,
                    r.Buildings_ID,
                    BuildingName = r.Buildings.Name,
                    r.UnitId,
                    UnitNo = r.Unit.No,
                    r.PaymentPlanId,
                    r.SharingUsers
                })

                .ToListAsync();

            return new VM_Resault
            {
                message = "Success",
                code = 200,
                error = false,
                data = requests.Cast<object>().ToList()
            };
        }
    }
}
