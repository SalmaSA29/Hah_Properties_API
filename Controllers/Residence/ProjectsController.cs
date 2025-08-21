using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalAPI.Models;
using PostAPI.Repository.Residence;
using System;
using System.Collections.Generic;
using System.Linq;
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
        [Authorize]
        public async Task<IActionResult> Create(Projects project)
        {
            var HRcode = HttpContext.User.Claims.FirstOrDefault(c => c.Type.ToString().Equals("UserHRCode", StringComparison.InvariantCultureIgnoreCase));
            string codeHr = HRcode.Value;
            var result = await ProjectRepo.Create(project, codeHr);

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
        [Authorize]
        public async Task<IActionResult> Update([FromRoute] int id, Projects project)
        {
            var HRcode = HttpContext.User.Claims.FirstOrDefault(c => c.Type.ToString().Equals("UserHRCode", StringComparison.InvariantCultureIgnoreCase));
            string codeHr = HRcode.Value;
            var result = await ProjectRepo.Update(id, project, codeHr);
            return StatusCode(result.code, result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(List<int> ids)
        {
            var result = await ProjectRepo.Delete(ids);
            return StatusCode(result.code);
        }
    }
}
