using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CashMUsers
    {
        public int CashUsers { get; set; }
        public string UserHrCode { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int? CashLevel { get; set; }
    }
}
