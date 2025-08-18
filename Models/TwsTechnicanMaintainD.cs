using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsTechnicanMaintainD
    {
        public string DocNo { get; set; }
        public string TechnicanId { get; set; }
        public string Comments { get; set; }

        public virtual TjobOrderMaintainM DocNoNavigation { get; set; }
        public virtual TwsTechnican Technican { get; set; }
    }
}
