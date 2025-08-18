using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalAPI.Models;
using PortalAPI.Repository;
using PortalAPI.Services;

namespace PortalAPI.Controllers
{
    [RestrictUserAccess("ahmed.shafeek", "hr.ticketing")]
    [Authorize]
    [ApiExplorerSettings(GroupName = "Portal")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        Employee_Interface employeeRepository;
        public EmployeeController(Employee_Interface _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

        [HttpGet]
        [Route("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            try
            {
                var employee = await employeeRepository.GetEmployees();
                if (employee == null)
                {
                    return NotFound();
                }
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}