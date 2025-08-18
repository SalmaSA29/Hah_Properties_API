using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecRequiredJobsDet
    {
        public int Id { get; set; }
        public int? RequiredId { get; set; }
        public string Requirement { get; set; }
        public string Locations { get; set; }

        public virtual HrRecRequiredJobs Required { get; set; }
    }
}
