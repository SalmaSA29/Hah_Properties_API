using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NPOI.HPSF;
using PortalAPI.Models;
using PortalAPI.Services;
using PortalAPI.ViewModel;
using PostAPI.Repository.Residence;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Controllers.Residence
{
    [ApiExplorerSettings(GroupName = "Residence")]
    [Route("api/[controller]")]
    [ApiController]
    public class UnitsController : ControllerBase
    {
        private readonly Units_Interface UnitsRepo;

        public UnitsController(Units_Interface unitsRepo)
        {
            UnitsRepo = unitsRepo;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create([FromForm] Units unit)
        {
            var mediaId = await Media_Service.SaveMedia(unit.Media);
            unit.Attach = mediaId;
            var HRcode = HttpContext.User.Claims.FirstOrDefault(c => c.Type.ToString().Equals("UserHRCode", StringComparison.InvariantCultureIgnoreCase));
            string codeHr = HRcode.Value;
            var result = await UnitsRepo.Create(unit, codeHr);
            return StatusCode(result.code, result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await UnitsRepo.GetAll();
            return StatusCode(result.code, result);
        }

        [HttpGet]
        [Route("building/{buildingId}")]
        public async Task<IActionResult> GetByBuilding(int buildingId)
        {
            var result = await UnitsRepo.GetByBuilding(buildingId);
            return StatusCode(result.code, result);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(int id, [FromForm]Units updateUnit)
        {
            var mediaId = await Media_Service.SaveMedia(updateUnit.Media);
            updateUnit.Attach = mediaId;
            var HRcode = HttpContext.User.Claims.FirstOrDefault(c => c.Type.ToString().Equals("UserHRCode", StringComparison.InvariantCultureIgnoreCase));
            string codeHr = HRcode.Value;

            var result = await UnitsRepo.Update(id, updateUnit, codeHr);
            return StatusCode(result.code, result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(List<int> ids)
        {
            var result = await UnitsRepo.Delete(ids);
            return StatusCode(result.code);
        }

        [HttpGet]
        [Route("attachment/{id}")]
        public IActionResult GetAttachment(string id)
        {
            var filePath = Path.Combine("Uploads", id);

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound(new VM_Resault()
                {
                    error = true,
                    message = "Media not found",
                    code = 404
                });
            }

            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            return File(fileStream, "application/pdf", id);
        }

        [HttpGet]
        [Route("paymentPlans")]
        public async Task<IActionResult> GetPlans()
        {
            var result = await UnitsRepo.GetAllPlans();
            return StatusCode(result.code, result);
        }
    }
}
