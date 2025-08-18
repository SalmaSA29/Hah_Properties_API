using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PortalAPI.Services
{
    public class RestrictUserAccessAttribute : ActionFilterAttribute
    {
        private readonly string[] _allowedUsers;
        public RestrictUserAccessAttribute(params string[] allowedUsers)
        {
            _allowedUsers = allowedUsers;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {

            var emailClaim = context.HttpContext.User.Claims.FirstOrDefault(c => c.Type.Equals("Email", StringComparison.InvariantCultureIgnoreCase));
            var userEmail = emailClaim?.Value;

            if (userEmail != null && !_allowedUsers.Contains(userEmail.ToLower()))
            {
                context.Result = new ForbidResult(); // Return 403 Forbidden
            }

            base.OnActionExecuting(context);
        }
    }
}
