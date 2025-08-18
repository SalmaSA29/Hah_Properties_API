using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingApproval
    {
        public int ApprovalId { get; set; }
        public string ApprovalDescription { get; set; }
        public int? Index { get; set; }
        public int? Duration { get; set; }
    }
}
