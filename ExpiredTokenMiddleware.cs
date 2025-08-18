using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PortalAPI
{
    public class ExpiredTokenMiddleware
    {
        private readonly RequestDelegate _next;

        public ExpiredTokenMiddleware(RequestDelegate next)
        {
            _next = next;

        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Response.Headers["Token-Expired"] == "True")
            {
                context.Response.StatusCode = 419;
                // DO NOT CALL NEXT. THIS SHORTCIRCUITS THE PIPELINE
            }
            else
            {
                await _next(context);
            }
        }
    }
}
