using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanActualDateM
    {
        public TprPlanActualDateM()
        {
            TprPlanActualDateD = new HashSet<TprPlanActualDateD>();
        }

        public string ProjectId { get; set; }

        public virtual ICollection<TprPlanActualDateD> TprPlanActualDateD { get; set; }
    }
}
