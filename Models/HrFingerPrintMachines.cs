using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrFingerPrintMachines
    {
        public int Id { get; set; }
        public int? FgrpId { get; set; }
        public string MacName { get; set; }
        public string MacIp { get; set; }
        public string MacSn { get; set; }
        public string MacPort { get; set; }
        public bool? InVpn { get; set; }
    }
}
