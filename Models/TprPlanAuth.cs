using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanAuth
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int StepNo { get; set; }
        public bool? HasSubmit { get; set; }
        public bool? HasRevised { get; set; }
        public int? SubmitUser { get; set; }
        public int? RevisedUser { get; set; }
        public int? ApprovedUser { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
