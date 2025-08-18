using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MainLog
    {
        public int LogId { get; set; }
        public string SysName { get; set; }
        public string PageName { get; set; }
        public string UserId { get; set; }
        public string ActionState { get; set; }
        public string ActionItem { get; set; }
        public DateTime? InDate { get; set; }
    }
}
