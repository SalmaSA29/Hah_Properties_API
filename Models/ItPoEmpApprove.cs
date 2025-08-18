using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItPoEmpApprove
    {
        public int Id { get; set; }
        public string UserHrCode { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool? AdminApproval1 { get; set; }
        public bool? AdminApproval2 { get; set; }
        public bool? AdminApproval3 { get; set; }
        public byte[] Signature { get; set; }
    }
}
