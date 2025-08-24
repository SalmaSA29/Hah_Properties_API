using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalAPI.Models;
using PortalAPI.Repository.Residence;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var HRcode = HttpContext.User.Claims.FirstOrDefault(c => c.Type.ToString().Equals("UserHRCode", StringComparison.InvariantCultureIgnoreCase));
            string codeHr = HRcode.Value;
            var result = await RequestRepo.Create(request, codeHr);
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
            var HRcode = HttpContext.User.Claims.FirstOrDefault(c => c.Type.ToString().Equals("UserHRCode", StringComparison.InvariantCultureIgnoreCase));
            string codeHr = HRcode.Value;
            var result = await RequestRepo.GetByUser(codeHr);
            return StatusCode(result.code, result);
        }

        [HttpPatch("{id}/status")]
        [Authorize]
        public async Task<IActionResult> PatchStatus(int id, [FromQuery] int status)
        {
            var HRcode = HttpContext.User.Claims.FirstOrDefault(c => c.Type.ToString().Equals("UserHRCode", StringComparison.InvariantCultureIgnoreCase));
            string codeHr = HRcode.Value;
            var result = await RequestRepo.PatchStatus(id, status, codeHr);
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
