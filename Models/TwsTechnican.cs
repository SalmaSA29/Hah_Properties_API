using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsTechnican
    {
        public TwsTechnican()
        {
            TwsTechnicanD = new HashSet<TwsTechnicanD>();
            TwsTechnicanMaintainD = new HashSet<TwsTechnicanMaintainD>();
        }

        public string TechnicanId { get; set; }
        public string TechnicanName { get; set; }
        public string JobId { get; set; }
        public string WorkLocation { get; set; }

        public virtual ICollection<TwsTechnicanD> TwsTechnicanD { get; set; }
        public virtual ICollection<TwsTechnicanMaintainD> TwsTechnicanMaintainD { get; set; }
    }
}
