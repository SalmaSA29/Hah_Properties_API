using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class AisLog
    {
        public int LogId { get; set; }
        public string UserId { get; set; }
        public string ActionState { get; set; }
        public DateTime? InDate { get; set; }
    }
}
