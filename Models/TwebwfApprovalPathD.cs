using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfApprovalPathD
    {
        public int ApprovalPathId { get; set; }
        public string TitleId { get; set; }
        public int DetailApprovalId { get; set; }
        public string Description { get; set; }
        public string DefaultHrCode { get; set; }
        public bool? HavException { get; set; }
        public string TitleIdAlternative { get; set; }

        public virtual TwebwfApprovalPathM ApprovalPath { get; set; }
    }
}
