using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using PortalAPI.Models;
using PortalAPI.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Repository.AIS
{
    public class Employees_Lookup_Repository : Employees_Lookup_Interface
    {
        private AISContext AISContext { get; set; }
        public Employees_Lookup_Repository(AISContext context)
        { 
            AISContext = context;
        }

        public async Task<VM_Resault> GetAll()
        {
            var x = await (from p in AISContext.TwebWfEmployee
                           select new  VM_TwebWFEmployee
                           {
                               UserHrCode = p.UserHrCode,
                               Name = p.Name,
                               DepartmentId = p.DepartmentId,
                               Email = p.Email,
                           }).ToListAsync();
            //var result = await AISContext.TwebWfEmployee.ToListAsync();
           
            return new VM_Resault
            {
                error = false,
                code = 200,
                message = "Success",
                data = x.Cast<object>().ToList()
            };
        }
    }
}
