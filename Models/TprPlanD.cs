using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanD
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int StepNo { get; set; }
        public DateTime? PlanningDate { get; set; }
        public int? Weight { get; set; }
        public int? ManHour { get; set; }
        public DateTime? ActualDate { get; set; }
        public int? Dif { get; set; }
        public string Day { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual TprPlan TprPlan { get; set; }
    }
}
