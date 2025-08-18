using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkProcurementApproval
    {
        public int ProcApprovalId { get; set; }
        public string ApprovalDescription { get; set; }
        public int Index { get; set; }
        public int? ProcTypeId { get; set; }
        public int? Duration { get; set; }
        public int? ProcAppTypeId { get; set; }
    }
}
