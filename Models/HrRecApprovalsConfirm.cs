using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecApprovalsConfirm
    {
        public int AppId { get; set; }
        public int? GroupId { get; set; }
        public string SendOffer { get; set; }
        public string ApprovalConfirm1 { get; set; }
        public string ApprovalConfirm2 { get; set; }
    }
}
