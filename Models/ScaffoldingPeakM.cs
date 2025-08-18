using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScaffoldingPeakM
    {
        public ScaffoldingPeakM()
        {
            ScaffoldingOpeningBalanceD = new HashSet<ScaffoldingOpeningBalanceD>();
            ScaffoldingPeakD = new HashSet<ScaffoldingPeakD>();
            ScaffoldingReleaseD = new HashSet<ScaffoldingReleaseD>();
            ScaffoldingRequiredD = new HashSet<ScaffoldingRequiredD>();
        }

        public string ProjectId { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<ScaffoldingOpeningBalanceD> ScaffoldingOpeningBalanceD { get; set; }
        public virtual ICollection<ScaffoldingPeakD> ScaffoldingPeakD { get; set; }
        public virtual ICollection<ScaffoldingReleaseD> ScaffoldingReleaseD { get; set; }
        public virtual ICollection<ScaffoldingRequiredD> ScaffoldingRequiredD { get; set; }
    }
}
