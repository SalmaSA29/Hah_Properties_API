using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrApprovalConfirm
    {
        public int Id { get; set; }
        public string ConfirmName { get; set; }
        public string HrUserCode { get; set; }
    }
}
