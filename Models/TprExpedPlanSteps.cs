using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprExpedPlanSteps
    {
        public int StepNo { get; set; }
        public string StepName { get; set; }
        public string Comments { get; set; }
        public double? DefaultWeight { get; set; }
        public int? ProcPlanStep { get; set; }
        public bool? Active { get; set; }
    }
}
