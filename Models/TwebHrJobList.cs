using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebHrJobList
    {
        public TwebHrJobList()
        {
            TwebHrAttendanceSummary = new HashSet<TwebHrAttendanceSummary>();
        }

        public string JobListId { get; set; }
        public string JobListName { get; set; }
        public string JobListCat { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<TwebHrAttendanceSummary> TwebHrAttendanceSummary { get; set; }
    }
}
