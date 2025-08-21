using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalAPI.Models;
using PortalAPI.Repository.Residence;
using PortalAPI.Services;
using PortalAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostAPI.Repository.Residence
{
    public class Projects_Repository : Projects_Interface
    {
        private readonly ResidenceContext ResidenceContext;
        private readonly Buildings_Interface BuildingRepository;
        public Projects_Repository(ResidenceContext residenceContext, Buildings_Interface buildingInterface)
        {
            ResidenceContext = residenceContext;
            BuildingRepository = buildingInterface;
        }

        public async Task<VM_Resault> Create(Projects project, string hrCode)
        {
            project.In_Date = DateTime.Now;
            project.In_User = hrCode;
            var newEntity = (await ResidenceContext.Projects.AddAsync(project)).Entity;
            await ResidenceContext.SaveChangesAsync();

            var result = new VM_Resault();
            result.message = "Created";
            result.code = 200;
            result.data = new List<object>() { (object)newEntity };
            result.error = false;

            return result;
        }

        public async Task<VM_Resault> Delete(List<int> ids)
        {
            
            var range = await ResidenceContext.Projects
                .Include(p => p.Buildings)
                .Where(p => ids.Contains(p.ID))
                .ToListAsync();

            foreach(var project in range)
            {
                foreach(var building in project.Buildings)
                {
                    await BuildingRepository.Delete(new List<int> { building.ID });
                }
                project.IsActive = false;
            }

            // ResidenceContext.RemoveRange(range);
            ResidenceContext.SaveChanges();

            var result = new VM_Resault();
            result.message = "Deleted Projects";
            result.code = 204;
            result.error = false;
            return result;
        }

        public async Task<VM_Resault> GetAll()
        {
            var result = new VM_Resault();
            result.message = "Success";
            result.data =  (await ResidenceContext.Projects.Where(p => p.IsActive == true).ToListAsync()).Cast<object>().ToList();

            result.code = 200;
            result.error = false;
            return result;
        }

        public async Task<VM_Resault> Update(int id, Projects projectUpdate, string hrCode)
        {
            var result = new VM_Resault();
            var element = await ResidenceContext.Projects.FirstOrDefaultAsync(p => p.ID == id);

            if (element == null)
            {
                result.message = "Project not found";
                result.code = 404;
                result.error = true;
                return result;
            }
            element.Up_Date = DateTime.Now;
            element.Name = projectUpdate.Name;
            element.Description = projectUpdate.Description;
            element.Up_User = hrCode;

            ResidenceContext.Projects.Update(element);
            await ResidenceContext.SaveChangesAsync();

            result.message = "Project updated successfully";
            result.data = new List<object>(){ (object)element };
            result.code = 200;
            return result;
        }
    }
}
