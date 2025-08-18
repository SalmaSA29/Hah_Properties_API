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
    [RestrictUserAccess("ahdmed.test", "catalog.api")]
    [Authorize]
    [ApiExplorerSettings(GroupName = "Catalog")]
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        Items_Interface ItemsRepository;
        public ItemsController(Items_Interface _ItemsRepository)
        {
            ItemsRepository = _ItemsRepository;
        }

        [HttpGet]
        [Route("GetItems")]
        public async Task<IActionResult> GetItemsBySAPCode(string Query)
        {
            try
            {
                var Items = await ItemsRepository.GetItems(Query);
                if (Items == null)
                {
                    return NotFound();
                }
                return Ok(Items);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
    