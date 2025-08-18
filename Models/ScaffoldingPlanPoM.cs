using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScaffoldingPlanPoM
    {
        public ScaffoldingPlanPoM()
        {
            ScaffoldingPlanPoD = new HashSet<ScaffoldingPlanPoD>();
        }

        public string ProjectId { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<ScaffoldingPlanPoD> ScaffoldingPlanPoD { get; set; }
    }
}
