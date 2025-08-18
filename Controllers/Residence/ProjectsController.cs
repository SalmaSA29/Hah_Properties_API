using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalAPI.Models;
using PostAPI.Repository.Residence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PostAPI.Controllers.Residence
{
    [ApiExplorerSettings(GroupName = "Residence")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly Projects_Interface ProjectRepo;
        public ProjectsController(Projects_Interface projectRepo)
        {
            ProjectRepo = projectRepo;
        }
        [HttpPost]
        public async Task<IActionResult> Create(Projects project)
        {
            var hrCodeClaim = HttpContext.User.FindFirst("hrCode");
            var result = await ProjectRepo.Create(project, "hrCodeClaim.Value");

            // based on convention preference, this could be CreatedAtRoute method with status code 204
            return StatusCode(result.code, result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await ProjectRepo.GetAll();
            return StatusCode(result.code, result);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, Projects project)
        {
            var hrCodeClaim = HttpContext.User.FindFirst("user_hrcode");
            var result = await ProjectRepo.Update(id, project, "hrCodeClaim.Value");
            return StatusCode(result.code, result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(List<int> ids)
        {
            var result = await ProjectRepo.Delete(ids);
            return StatusCode(result.code, result);
        }
    }
}
