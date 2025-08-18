using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScaffoldingPlanTransferFromProjectsM
    {
        public ScaffoldingPlanTransferFromProjectsM()
        {
            ScaffoldingPlanTransferFromProjectsD = new HashSet<ScaffoldingPlanTransferFromProjectsD>();
        }

        public string ProjectId { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<ScaffoldingPlanTransferFromProjectsD> ScaffoldingPlanTransferFromProjectsD { get; set; }
    }
}
