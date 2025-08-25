using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalAPI.Repository.AIS;
using System.Threading.Tasks;

namespace PortalAPI.Controllers.AIS
{
    [ApiExplorerSettings(GroupName = "AIS")]
    [Route("api/[controller]")]
    [ApiController] 
    public class EmployeesController : ControllerBase
    {
        private Employees_Interface EmployeesRepo { get; set; }

        public EmployeesController(Employees_Interface repo)
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
