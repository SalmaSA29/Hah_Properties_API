using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScPaymentApproval
    {
        public int ScPaymentApprovalId { get; set; }
        public string ApprovalDescription { get; set; }
        public int? ScPaymentTypeId { get; set; }
        public int? Index { get; set; }
        public int? ScApprovalTypeId { get; set; }
        public int? Duration { get; set; }
    }
}
