using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingPoD
    {
        public int PoDId { get; set; }
        public int? MrId { get; set; }
        public int? ItemCode { get; set; }
        public int? Qty { get; set; }
        public int? PoId { get; set; }
        public double? TotalAm { get; set; }
    }
}
