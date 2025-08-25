using Microsoft.EntityFrameworkCore;
using PortalAPI.Models;
using PortalAPI.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Repository.AIS
{
    public class Employees_Repository : Employees_Interface
    {
        private AISContext AISContext { get; set; }
        public Employees_Repository(AISContext context)
        { 
            AISContext = context;
        }

        public async Task<VM_Resault> GetAll()
        {
            var result = await AISContext.Employees.ToListAsync();
            return new VM_Resault
            {
                error = false,
                code = 200,
                message = "Success",
                data = result.Cast<object>().ToList()
            };
        }
    }
}
