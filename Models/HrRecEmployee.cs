using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecEmployee
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public int? SubGroupId { get; set; }
        public string UserHrCode { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Color { get; set; }
        public bool? AdminGroups { get; set; }
        public bool? AdminOffer { get; set; }
        public bool? AdminApproval1 { get; set; }
        public bool? AdminApproval2 { get; set; }
        public byte[] Signature { get; set; }
        public bool? ReciveHiringNot { get; set; }
        public bool? IsPersonal { get; set; }
        public bool? FingerPrintAdmin { get; set; }
        public bool? PersonalReadOnly { get; set; }
        public bool? IsActive { get; set; }
    }
}
