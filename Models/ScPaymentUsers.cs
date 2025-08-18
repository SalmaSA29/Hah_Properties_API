using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScPaymentUsers
    {
        public int PayId { get; set; }
        public string UserHrCode { get; set; }
        public string Email { get; set; }
        public int? ServiceId { get; set; }
    }
}
