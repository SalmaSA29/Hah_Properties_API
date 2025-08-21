using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalAPI.Models;
using PortalAPI.Repository.Residence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalAPI.Controllers.Residence
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly Requests_Interface RequestRepo;

        public RequestsController(Requests_Interface requestRepo)
        {
            RequestRepo = requestRepo;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(Requests request)
        {
            var hrCodeClaim = HttpContext.User.FindFirst("user_hrcode");
            var result = await RequestRepo.Create(request, hrCodeClaim.Value);
            return StatusCode(result.code, result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await RequestRepo.GetAll();
            return StatusCode(result.code, result);
        }

        [HttpGet("user")]
        [Authorize]
        public async Task<IActionResult> GetByUser()
        {
            var hrCodeClaim = HttpContext.User.FindFirst("user_hrcode");
            var result = await RequestRepo.GetByUser(hrCodeClaim.Value);
            return StatusCode(result.code, result);
        }

        [HttpPatch("{id}/status")]
        [Authorize]
        public async Task<IActionResult> PatchStatus(int id, [FromQuery] int status)
        {
            var hrCodeClaim = HttpContext.User.FindFirst("user_hrcode");
            var result = await RequestRepo.PatchStatus(id, status, hrCodeClaim.Value);
            return StatusCode(result.code);
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> Delete(List<int> ids)
        {
            var result = await RequestRepo.Delete(ids);
            return StatusCode(result.code, result);
        }
    }
}
