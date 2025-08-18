using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrTicketAuthority
    {
        public int TkId { get; set; }
        public string TkUserHrcode { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
