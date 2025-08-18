using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingSelectedSuppliers
    {
        public int Serial { get; set; }
        public int? MrId { get; set; }
        public double? SupplierId { get; set; }
        public string ItemCode { get; set; }
    }
}
