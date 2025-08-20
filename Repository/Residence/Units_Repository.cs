using PortalAPI.Models;
using PortalAPI.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PortalAPI.Services;

namespace PostAPI.Repository.Residence
{
    public class Units_Repository : Units_Interface
    {
        private readonly ResidenceContext ResidenceContext;

        public Units_Repository(ResidenceContext context)
        {
            ResidenceContext = context;
        }

        public async Task<VM_Resault> Create(Units unit, string hrCode)
        {
            // Check if the building exists
            if (!ResidenceContext.Buildings.Any(b => b.Id == unit.BuildingsId))
            {
                return new VM_Resault
                {
                    message = "Building not found",
                    code = 404,
                    error = true
                };
            }

            unit.InDate = DateTime.Now;
            unit.InUser = hrCode;

            var newEntity = (await ResidenceContext.Units.AddAsync(unit)).Entity;

            await ResidenceContext.SaveChangesAsync();

            // Saves the 1:M relation between unit and payment plans
            foreach (var item in unit.UnitPaymentPlanIds)
            {
                if (!ResidenceContext.PaymentPlans.Any(p => p.Id == item))  // Payment plan does not exist
                {
                    ResidenceContext.Units.Remove(newEntity);               // roll back the addition
                    await ResidenceContext.SaveChangesAsync();

                    return new VM_Resault
                    {
                        message = "Payment plan not found",
                        code = 404,
                        error = true,
                    };
                }
                await ResidenceContext.UnitPaymentPlan.AddAsync(new UnitPaymentPlan() { PaymentPlanId = item, UnitId = newEntity.Id });
            }
            await ResidenceContext.SaveChangesAsync();

            return new VM_Resault
            {
                message = "Unit created successfully",
                code = 201,
                error = false,
                data = new List<object> { newEntity }
            };
        }

        public async Task<VM_Resault> Delete(List<int> ids)
        {
            var units = await ResidenceContext.Units
                .Include(u => u.Requests)
                .Include(u => u.UnitPaymentPlan)
                .Where(u => ids.Contains(u.Id))
                .ToListAsync();

            //ResidenceContext.Units.RemoveRange(units);

            foreach (var unit in units)
            {
                foreach(var request in unit.Requests)
                {
                    request.IsActive = false;
                }
                foreach (var plan in unit.UnitPaymentPlan)
                {
                    plan.IsActive = false;
                }
                Media_Service.DeleteMedia(unit.Attach);
                unit.IsActive = false;
            }

            await ResidenceContext.SaveChangesAsync();

            return new VM_Resault
            {
                message = "Units deleted successfully",
                code = 204,
                error = false
            };
        }

        public async Task<VM_Resault> GetAll()
        {
            var units = await ResidenceContext.Units
                .Where(u => u.IsActive == true)
                .Select(u => new
                {
                    u.Id,
                    u.No,
                    u.Type,
                    u.Area,
                    u.Price,
                    u.Attach,
                    Building = new 
                        {
                            u.Buildings.Id, 
                            u.Buildings.Name 
                        },
                    PaymentPlans = u.UnitPaymentPlan
                        .Select(up => new
                        {
                            up.PaymentPlan.Id,
                            up.PaymentPlan.Plan
                        })
                        .ToList()
                })
                .ToListAsync();

            return new VM_Resault
            {
                message = "Success",
                code = 200,
                error = false,
                data = units.Cast<object>().ToList()
            };
        }

        public async Task<VM_Resault> Update(int id, Units unitUpdate, string hrCode)
        {
            var unit = await ResidenceContext.Units.Include(u => u.UnitPaymentPlan).FirstOrDefaultAsync(u => u.Id == id);
            if (unit == null)
            {
                return new VM_Resault
                {
                    message = "Unit not found",
                    code = 404,
                    error = true
                };
            }

            // Check if the building exists (allow reassignment)
            if (!ResidenceContext.Buildings.Any(b => b.Id == unitUpdate.BuildingsId))
            {
                return new VM_Resault
                {
                    message = "Building not found",
                    code = 404,
                    error = true
                };
            }

            Media_Service.DeleteMedia(unit.Attach);

            unit.No = unitUpdate.No;
            unit.Type = unitUpdate.Type;
            unit.Area = unitUpdate.Area;
            unit.Price = unitUpdate.Price;
            unit.BuildingsId = unitUpdate.BuildingsId;
            unit.Attach = unitUpdate.Attach;
            unit.UpDate = DateTime.Now;
            unit.UpUser = hrCode;

            foreach(var unitPlan in unit.UnitPaymentPlan)
            {
                var toBeDeletedPlanRelations = ResidenceContext.UnitPaymentPlan.Where(up => up.UnitId == unit.Id);
                foreach(var plan in toBeDeletedPlanRelations)
                {
                    ResidenceContext.UnitPaymentPlan.Remove(plan);
                }
            }

            unitUpdate.UnitPaymentPlanIds = unitUpdate.UnitPaymentPlanIds
                .Distinct()
                .ToArray(); //remove any duplication from request

            foreach(var planId in unitUpdate.UnitPaymentPlanIds)
            {
                ResidenceContext.UnitPaymentPlan.Add(new UnitPaymentPlan() { UnitId = unit.Id, PaymentPlanId = planId });
            }

            ResidenceContext.Units.Update(unit);
            await ResidenceContext.SaveChangesAsync();

            return new VM_Resault
            {
                message = "Unit updated successfully",
                code = 200,
                error = false,
                data = new List<object> { unit }
            };
        }

        public async Task<VM_Resault> GetByBuilding(int buildingId)
        {
            var units = await ResidenceContext.Units
               .Where(u => u.BuildingsId == buildingId && u.IsActive == true)
                .Select(u => new
                {
                    u.Id,
                    u.No,
                    u.Type,
                    u.Area,
                    u.Price,
                    u.Attach,
                    PaymentPlans = u.UnitPaymentPlan
                        .Select(up => new
                        {
                            up.PaymentPlan.Id,
                            up.PaymentPlan.Plan
                        })
                        .ToList()
                })
                .ToListAsync();

            return new VM_Resault
            {
                message = "Success",
                code = 200,
                error = false,
                data = units.Cast<object>().ToList()
            };
        }

        public async Task<VM_Resault> GetAllPlans()
        {
            var data = await ResidenceContext.PaymentPlans.ToListAsync();
            return new VM_Resault
            {
                message = "Success",
                code = 200,
                error = false,
                data = data.Cast<object>().ToList()
            };
        }
    }
}
