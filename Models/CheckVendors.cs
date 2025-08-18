using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CheckVendors
    {
        public string VendId { get; set; }
        public string VendName { get; set; }
        public int? VendType { get; set; }
    }
}
