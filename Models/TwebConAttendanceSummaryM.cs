using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebConAttendanceSummaryM
    {
        public DateTime Date { get; set; }
        public string ProjectId { get; set; }
        public bool? Revised { get; set; }
        public bool? Approved { get; set; }
    }
}
