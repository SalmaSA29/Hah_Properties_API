using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanStructD
    {
        public int PlanStruct { get; set; }
        public int StepNo { get; set; }

        public virtual TprPlanStructM PlanStructNavigation { get; set; }
    }
}
