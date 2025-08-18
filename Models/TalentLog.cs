using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TalentLog
    {
        public int LogId { get; set; }
        public string UserHrcode { get; set; }
        public string UserEmail { get; set; }
        public string ActionState { get; set; }
        public int? ActionItem { get; set; }
        public string ActionValue { get; set; }
        public DateTime? InDate { get; set; }
    }
}
