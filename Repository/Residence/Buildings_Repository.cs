using PortalAPI.Models;
using PortalAPI.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PortalAPI.Repository.Residence
{
    public class Buildings_Repository : Buildings_Interface
    {
        private readonly ResidenceContext ResidenceContext;
        public Buildings_Repository(ResidenceContext residenceContext)
        {
            ResidenceContext = residenceContext;
        }

        public async Task<VM_Resault> Create(Buildings building, string hrCode)
        {
            if(!ResidenceContext.Projects.Where(p => p.ID == building.Proj_ID).Any())    //project not found
            {
                return new VM_Resault
                {
                    message = "Project not found",
                    code = 404,
                    error = true,
                };
            }

            building.In_Date = DateTime.Now;
            building.In_User = hrCode;

            var newEntity = (await ResidenceContext.Buildings.AddAsync(building)).Entity;
            await ResidenceContext.SaveChangesAsync();

            return new VM_Resault
            {
                message = "Building created successfully",
                code = 201,
                error = false,
                data = new List<object> { newEntity }
            };
        }

        public async Task<VM_Resault> Delete(List<int> ids)
        {
            var range = await ResidenceContext.Buildings
                .Where(b => ids.Contains(b.ID))
                .ToListAsync();

            ResidenceContext.Buildings.RemoveRange(range);
            await ResidenceContext.SaveChangesAsync();

            return new VM_Resault
            {
                message = "Deleted",
                code = 204,
                error = false
            };
        }

        public async Task<VM_Resault> GetAll()
        {
            var buildings = await ResidenceContext.Buildings
                .ToListAsync();

            return new VM_Resault
            {
                message = "Success",
                code = 200,
                error = false,
                data = buildings.Cast<object>().ToList()
            };
        }

        public async Task<VM_Resault> Update(int id, Buildings buildingUpdate, string hrCode)
        {
            if (!ResidenceContext.Projects.Where(p => p.ID == buildingUpdate.Proj_ID).Any())    //project not found
            {
                return new VM_Resault
                {
                    message = "Project not found",
                    code = 404,
                    error = true,
                };
            }


            var element = await ResidenceContext.Buildings.FirstOrDefaultAsync(b => b.ID == id);

            if (element == null)
            {
                return new VM_Resault
                {
                    message = "Building not found",
                    code = 404,
                    error = true
                };
            }

            element.Name = buildingUpdate.Name;
            element.Up_Date = DateTime.Now;
            element.Up_User = hrCode;
            element.Proj_ID = buildingUpdate.Proj_ID; // allow project reassignment

            ResidenceContext.Buildings.Update(element);
            await ResidenceContext.SaveChangesAsync();

            return new VM_Resault
            {
                message = "Building updated successfully",
                code = 200,
                error = false,
                data = new List<object> { element }
            };
        }

        public async Task<VM_Resault> GetByProject(int projectId)
        {
            var buildings = await ResidenceContext.Buildings
                .Where(b => b.Proj_ID == projectId)
                .ToListAsync();

            return new VM_Resault
            {
                message = "Success",
                code = 200,
                error = false,
                data = buildings.Cast<object>().ToList()
            };
        }
    }
}
