using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkUsers
    {
        public int TrkId { get; set; }
        public string TrkUserHrcode { get; set; }
        public string Email { get; set; }
        public bool? Payments { get; set; }
        public bool? Procurement { get; set; }
        public bool? Purchasing { get; set; }
    }
}
