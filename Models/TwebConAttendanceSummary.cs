using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebConAttendanceSummary
    {
        public DateTime Date { get; set; }
        public string ProjectId { get; set; }
        public string JobListId { get; set; }
        public double? Count { get; set; }
    }
}
