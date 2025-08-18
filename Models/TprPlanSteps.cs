using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanSteps
    {
        public int StepNo { get; set; }
        public string StepName { get; set; }
        public string FormName { get; set; }
        public int? DefaultSubmitUser { get; set; }
        public int? DefaultRevisedUser { get; set; }
        public int? DefaultApprovedUser { get; set; }
        public int? DefaultHasSubmit { get; set; }
        public int? DefaultHasRevised { get; set; }
        public string ColorName { get; set; }
        public double? DefaultWeight { get; set; }
        public string UniqeName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public string Type { get; set; }
        public bool? Active { get; set; }
        public bool? OutOfEgypt { get; set; }
        public bool? UseInProgress { get; set; }
        public bool? ServiceAndAddendum { get; set; }
        public bool? FrequentAgrrement { get; set; }
    }
}
