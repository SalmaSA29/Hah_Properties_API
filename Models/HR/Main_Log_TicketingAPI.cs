using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models.HR
{
    public class Main_Log_TicketingAPI
    {
        [Key]
        public int Log_ID { get; set; }
        public string FunctionName { get; set; }
        public string IP_Address { get; set; }
        public string Email { get; set; }
        public string Action_State { get; set; }
        public string QueryString { get; set; }
        public string Parameter { get; set; }
        public DateTime? In_Date { get; set; }
    }
}
