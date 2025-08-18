using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanStructM
    {
        public TprPlanStructM()
        {
            TprPlanStructD = new HashSet<TprPlanStructD>();
        }

        public int PlanStruct { get; set; }
        public string PlanStructName { get; set; }

        public virtual ICollection<TprPlanStructD> TprPlanStructD { get; set; }
    }
}
