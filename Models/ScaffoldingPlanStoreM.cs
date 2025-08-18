using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScaffoldingPlanStoreM
    {
        public ScaffoldingPlanStoreM()
        {
            ScaffoldingPlanStoreD = new HashSet<ScaffoldingPlanStoreD>();
        }

        public string ProjectId { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<ScaffoldingPlanStoreD> ScaffoldingPlanStoreD { get; set; }
    }
}
