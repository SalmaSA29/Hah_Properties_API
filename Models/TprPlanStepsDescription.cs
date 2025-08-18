using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanStepsDescription
    {
        public int StepDescriptionNo { get; set; }
        public int StepNo { get; set; }
        public int PlanStruct { get; set; }
        public string StepDescription { get; set; }
        public string TargetUser { get; set; }
        public bool? SetActualDate { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public bool? IsActive { get; set; }
    }
}
