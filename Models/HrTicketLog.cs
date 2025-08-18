using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrTicketLog
    {
        public int LogId { get; set; }
        public int? Id { get; set; }
        public string ActionUser { get; set; }
        public string ActionState { get; set; }
        public string AssignTo { get; set; }
        public DateTime? ActionDate { get; set; }
        public bool? Status { get; set; }
        public string Comment { get; set; }
        public string Attached { get; set; }
        public int? DelayLevel { get; set; }
        public DateTime? DelayLastDate { get; set; }
    }
}
