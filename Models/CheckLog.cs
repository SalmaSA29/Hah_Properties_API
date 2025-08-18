using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CheckLog
    {
        public int LogId { get; set; }
        public int? SysId { get; set; }
        public int? PageId { get; set; }
        public int? UserId { get; set; }
        public string ActionState { get; set; }
        public int? ActionItem { get; set; }
        public int? ActionItem1 { get; set; }
        public int? ActionItem2 { get; set; }
        public DateTime? InDate { get; set; }
    }
}
