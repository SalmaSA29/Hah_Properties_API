using Microsoft.EntityFrameworkCore;
using PortalAPI.Models;
using PortalAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Repository
{
    public class Employee_Repository : Employee_Interface
    {
        AISContext db;
        public Employee_Repository(AISContext _db)
        {
            db = _db;
        }
        public async Task<VM_Resault> GetEmployees()
        {
            if (db != null)
            {
                List<SP_TicketingAPI_Employees> x = new List<SP_TicketingAPI_Employees>();
                //x = await db.SP_TicketingAPI_Employees.FromSql("SP_TicketingAPI_Employees").ToListAsync();
                if (x.Count > 0)
                {
                    return (new VM_Resault
                    {
                        code = 200,
                        error = false,
                        message = null,
                        data = x.Cast<object>().ToList()
                    });
                }
                else
                {
                    List<VM_Resault> V = new List<VM_Resault>()
                    {
                        new VM_Resault(){
                            code = 204, // No Content
                            error = true,
                            message = "No Content"
                        }
                    };
                    return V.FirstOrDefault();
                }
            }
            else
            {
                List<VM_Resault> V = new List<VM_Resault>()
                    {
                        new VM_Resault(){
                            code = 503, // Service Unavailable
                            error = true,
                            message = "Service Unavailable"
                        }
                    };
                return V.FirstOrDefault();
            }
        }
    }
}
