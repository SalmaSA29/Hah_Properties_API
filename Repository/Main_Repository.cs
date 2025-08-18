using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin.Security.Infrastructure;
using PortalAPI.Models;
using PortalAPI.Models.HR;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PortalAPI.Repository
{
    public class Main_Repository : Main_Interface
    {
        HRContext db;
        public Main_Repository(HRContext _db)
        {
            db = _db;
        }
        public void Main_Log(Main_Log_TicketingAPI LogEntity)
        {
            try
            {
                Main_Log_TicketingAPI Req = new Main_Log_TicketingAPI();
                Req.FunctionName = LogEntity.FunctionName;
                Req.Email = LogEntity.Email;
                Req.Action_State = LogEntity.Action_State;
                if (LogEntity.QueryString != null)
                {
                    Req.QueryString = LogEntity.QueryString.ToString();
                }
                Req.Parameter = LogEntity.Parameter;
                Req.In_Date = DateTime.Now;
                db.Main_Log_TicketingAPI.Add(Req);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
