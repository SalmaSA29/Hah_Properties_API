using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsTechnicanD
    {
        public string DocNo { get; set; }
        public string TechnicanId { get; set; }
        public double? ExpectedHours { get; set; }
        public double? ActualHours { get; set; }
        public string Comments { get; set; }

        public virtual TjobOrderM DocNoNavigation { get; set; }
        public virtual TwsTechnican Technican { get; set; }
    }
}
