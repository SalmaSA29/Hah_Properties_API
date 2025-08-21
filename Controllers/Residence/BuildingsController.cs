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
    [ApiExplorerSettings(GroupName = "Residence")]
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingsController : ControllerBase
    {
        private readonly Buildings_Interface BuildingRepo;

        public BuildingsController(Buildings_Interface buildingsRepo)
        {
            BuildingRepo = buildingsRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await BuildingRepo.GetAll();
            return StatusCode(result.code, result);
        }

        [HttpGet("project/{projectId}")]
        public async Task<IActionResult> GetByProject(int projectId)
        {
            var result = await BuildingRepo.GetByProject(projectId);
            return StatusCode(result.code, result);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(Buildings building)
        {
            var HRcode = HttpContext.User.Claims.FirstOrDefault(c => c.Type.ToString().Equals("UserHRCode", StringComparison.InvariantCultureIgnoreCase));
            string codeHr = HRcode.Value;
            var result = await BuildingRepo.Create(building, codeHr);
            return StatusCode(result.code, result);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Update(int id, Buildings buildingUpdate)
        {
            var HRcode = HttpContext.User.Claims.FirstOrDefault(c => c.Type.ToString().Equals("UserHRCode", StringComparison.InvariantCultureIgnoreCase));
            string codeHr = HRcode.Value;
            var result = await BuildingRepo.Update(id, buildingUpdate, codeHr);
            return StatusCode(result.code, result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(List<int> ids)
        {
            var result = await BuildingRepo.Delete(ids);
            return StatusCode(result.code);
        }
    }
}
