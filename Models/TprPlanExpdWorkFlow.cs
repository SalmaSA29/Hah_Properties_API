using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanExpdWorkFlow
    {
        public int Serial { get; set; }
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int StepNo { get; set; }
        public string UserId { get; set; }
        public string SubmitedToUser { get; set; }
        public int? Status { get; set; }
        public string Comments { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public bool? Read { get; set; }
        public int? SourceBeforeMove { get; set; }
    }
}
