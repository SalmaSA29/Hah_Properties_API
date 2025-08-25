using PortalAPI.Models;
using PortalAPI.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using PostAPI.Repository.Residence;

namespace PortalAPI.Repository.Residence
{
    public class Buildings_Repository : Buildings_Interface
    {
        private readonly ResidenceContext ResidenceContext;
        private readonly Units_Interface UnitsRepository;
        public Buildings_Repository(ResidenceContext residenceContext, Units_Interface unitRepository)
        {
            ResidenceContext = residenceContext;
            UnitsRepository = unitRepository;
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

            var newBuilding = ResidenceContext.Buildings
            .Include(b => b.Units)
            .Where(b => b.IsActive == true && b.ID == newEntity.ID)
            .Select(b => new
            {
                b.ID,
                b.Name,
                projectId = b.Proj_ID,
                projectName = b.Proj.Name
            });

            return new VM_Resault
            {
                message = "Building created successfully",
                code = 201,
                error = false,
                data = new List<object> { newBuilding }
            };
        }

        public async Task<VM_Resault> Delete(List<int> ids)
        {
            var range = await ResidenceContext.Buildings
                .Include(b => b.Units)
                .Where(b => ids.Contains(b.ID))
                .ToListAsync();

            foreach(var building in range)
            {
                foreach (var unit in building.Units)
                {
                    await UnitsRepository.Delete(new List<int>{ unit.ID });     // deletion now occurs in cycles of dependinces to assure all relations are inActive
                }
                building.IsActive = false;
            }

            //ResidenceContext.Buildings.RemoveRange(range);
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
                .Include(b => b.Units)
                .Where(b => b.IsActive == true)
                .Select(b => new
                {
                    b.ID,
                    b.Name,
                    projectId = b.Proj_ID,
                    projectName = b.Proj.Name
                })
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

            var updatedBuilding = ResidenceContext.Buildings
            .Include(b => b.Units)
            .Where(b => b.IsActive == true && b.ID == id)
            .Select(b => new
            {
                b.ID,
                b.Name,
                projectId = b.Proj_ID,
                projectName = b.Proj.Name
            });

            return new VM_Resault
            {
                message = "Building updated successfully",
                code = 200,
                error = false,
                data = new List<object> { updatedBuilding }
            };
        }

        public async Task<VM_Resault> GetByProject(int projectId)
        {
            var buildings = await ResidenceContext.Buildings
                .Include(b => b.Units)
                .Where(b => b.IsActive == true && b.Proj_ID == projectId)
                .Select(b => new
                {
                    b.ID,
                    b.Name,
                    projectName = b.Proj.Name
                })
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
