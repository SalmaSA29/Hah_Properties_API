using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalAPI.Repository.AIS;
using System.Threading.Tasks;

namespace PortalAPI.Controllers.AIS
{
    [ApiExplorerSettings(GroupName = "AIS")]
    [Route("api/[controller]")]
    [ApiController] 
    public class Employees_LookupController : ControllerBase
    {
        private Employees_Lookup_Interface EmployeesRepo { get; set; }

        public Employees_LookupController(Employees_Lookup_Interface repo)
        {
            EmployeesRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await EmployeesRepo.GetAll();
            return StatusCode(result.code, result);
        }
    }
}
