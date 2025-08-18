using Microsoft.AspNetCore.Http;
using PortalAPI.Models;
using PortalAPI.Models.HR;
using PortalAPI.Repository;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingAPI.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context, HRContext db)
        {
            var Email = context.User.Claims.FirstOrDefault(c => c.Type.ToString().Equals("Email", StringComparison.InvariantCultureIgnoreCase));
            string QueryString = "";
            if (context.Request.QueryString != null)
            {
                QueryString = context.Request.QueryString.ToString();
            }

            var bodyStr = "";
            var req = context.Request;

            // Allows using several time the stream in ASP.Net Core
            req.EnableBuffering();

            // Arguments: Stream, Encoding, detect encoding, buffer size 
            // AND, the most important: keep stream opened
            using (StreamReader reader = new StreamReader(req.Body, Encoding.UTF8, true, 1024, true))
            {
                bodyStr = reader.ReadToEnd();
            }

            // Rewind, so the core is not lost when it looks at the body for the request
            req.Body.Position = 0;

            //var request = context.Request;
            //var buffer = new byte[Convert.ToInt32(request.ContentLength)];
            //await request.Body.ReadAsync(buffer, 0, buffer.Length);

            //var requestcontent = Encoding.UTF8.GetString(buffer);
            //request.Body.Position = 0;
            try
            {
                Main_Log_TicketingAPI Req = new Main_Log_TicketingAPI();
                Req.FunctionName = context.Request.Path;
                Req.Email = Email?.Value;
                Req.Action_State = context.Request.Method;
                if (QueryString != null)
                {
                    Req.QueryString = QueryString;
                }
                Req.Parameter = bodyStr;
                Req.In_Date = DateTime.Now;
                db.Main_Log_TicketingAPI.Add(Req);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                string Res = ex.Message;
            }

            //_log.Main_Log(new Main_Log_TicketingAPI()
            //{
            //    FunctionName = context.Request.Path,
            //    Email = Email?.Value,
            //    Action_State = context.Request.Method,
            //    QueryString = QueryString,
            //    Parameter = requestcontent,
            //    In_Date = DateTime.Now,
            //});

            await _next(context);
        }
    }
}
