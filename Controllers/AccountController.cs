using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PortalAPI.Models;
using PortalAPI.Repository;
using PortalAPI.ViewModel;

namespace PortalAPI.Controllers
{
    [ApiExplorerSettings(GroupName = "Portal")]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        Account_Interface AccountRepository;
        public AccountController(Account_Interface _AccountRepository)
        {
            AccountRepository = _AccountRepository;
        }

        /// <summary>
        /// Login To Create the Token
        /// </summary>
        [HttpPost]
        [Route("LoginToken")]
        public IActionResult LoginToken(VM_LoginToken Login)
        {
            try
            {
                var employee = AccountRepository.Login(Login);
                if (employee == null)
                {
                    return NotFound();
                }
                return Ok(employee);
            }
            catch (Exception ex)
            {
                string x = ex.Message;
                return BadRequest();
            }
        }
    }
}