using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfApprovalPathM
    {
        public TwebwfApprovalPathM()
        {
            TwebwfApprovalPathBusinessUnitD = new HashSet<TwebwfApprovalPathBusinessUnitD>();
            TwebwfApprovalPathD = new HashSet<TwebwfApprovalPathD>();
        }

        public int ApprovalPathId { get; set; }
        public string ApprovalPathTitle { get; set; }
        public string Description { get; set; }
        public bool? NeedManagerApproval { get; set; }
        public bool? NeedDirectorApproval { get; set; }
        public bool? NeedProjectManagerApproval { get; set; }

        public virtual ICollection<TwebwfApprovalPathBusinessUnitD> TwebwfApprovalPathBusinessUnitD { get; set; }
        public virtual ICollection<TwebwfApprovalPathD> TwebwfApprovalPathD { get; set; }
    }
}
