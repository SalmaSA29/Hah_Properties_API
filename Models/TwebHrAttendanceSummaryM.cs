using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebHrAttendanceSummaryM
    {
        public TwebHrAttendanceSummaryM()
        {
            TwebHrAttendanceSummary = new HashSet<TwebHrAttendanceSummary>();
        }

        public DateTime Date { get; set; }
        public string ProjectId { get; set; }
        public bool? Revised { get; set; }
        public bool? Approved { get; set; }

        public virtual ICollection<TwebHrAttendanceSummary> TwebHrAttendanceSummary { get; set; }
    }
}
