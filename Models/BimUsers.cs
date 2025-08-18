using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class BimUsers
    {
        public int BimId { get; set; }
        public string BimUserCode { get; set; }
        public string Email { get; set; }
        public bool? Auth { get; set; }
    }
}
