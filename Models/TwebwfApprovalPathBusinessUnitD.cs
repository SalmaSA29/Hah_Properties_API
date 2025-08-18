using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfApprovalPathBusinessUnitD
    {
        public int ApprovalPathId { get; set; }
        public string DepartmentId { get; set; }
        public string ServiceId { get; set; }

        public virtual TwebwfApprovalPathM ApprovalPath { get; set; }
    }
}
