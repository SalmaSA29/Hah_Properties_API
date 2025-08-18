using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecRequiredJobs
    {
        public HrRecRequiredJobs()
        {
            HrRecRequiredJobsDet = new HashSet<HrRecRequiredJobsDet>();
        }

        public int RequiredId { get; set; }
        public int? GroupId { get; set; }
        public int? LocationId { get; set; }
        public int? JobId { get; set; }
        public string Major { get; set; }
        public int? ReqCount { get; set; }
        public string UserHrCode { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? NeededDate { get; set; }
        public int? RequestId { get; set; }

        public virtual ICollection<HrRecRequiredJobsDet> HrRecRequiredJobsDet { get; set; }
    }
}
