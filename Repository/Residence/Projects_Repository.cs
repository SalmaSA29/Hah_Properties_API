using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalAPI.Models;
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
        public Projects_Repository(ResidenceContext residenceContext)
        {
            ResidenceContext = residenceContext;
        }

        public async Task<VM_Resault> Create(Projects project, string hrCode)
        {
            project.InDate = DateTime.Now;
            project.InUser = hrCode;
            var newEntity = (await ResidenceContext.Projects.AddAsync(project)).Entity;
            await ResidenceContext.SaveChangesAsync();

            var result = new VM_Resault();
            result.message = "Deleted";
            result.code = 200;
            result.data = new List<object>() { (object)newEntity };
            result.error = false;

            return result;
        }

        public async Task<VM_Resault> Delete(List<int> ids)
        {
            
            var range = await ResidenceContext.Projects.Where(p => ids.Contains(p.Id)).ToListAsync();

            ResidenceContext.RemoveRange(range);
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
            result.data =  (await ResidenceContext.Projects.ToListAsync()).Cast<object>().ToList();

            result.code = 200;
            result.error = false;
            return result;
        }

        public async Task<VM_Resault> Update(int id, Projects projectUpdate, string hrCode)
        {
            var result = new VM_Resault();
            var element = await ResidenceContext.Projects.FirstOrDefaultAsync(p => p.Id == id);

            if (element == null)
            {
                result.message = "Project not found";
                result.code = 404;
                result.error = true;
                return result;
            }

            element.UpDate = DateTime.Now;
            element.Name = projectUpdate.Name;
            element.Description = projectUpdate.Description;
            element.UpUser = hrCode;

            ResidenceContext.Projects.Update(element);
            await ResidenceContext.SaveChangesAsync();

            result.message = "Project updated successfully";
            result.data = new List<object>(){ (object)element };
            result.code = 200;
            return result;
        }
    }
}
