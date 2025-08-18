using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScaffoldingReleaseD
    {
        public string ProjectId { get; set; }
        public string SystemId { get; set; }
        public decimal Value { get; set; }
        public DateTime? RequiredFrom { get; set; }
        public string Comments { get; set; }

        public virtual ScaffoldingPeakM Project { get; set; }
    }
}
