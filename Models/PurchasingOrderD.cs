using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PurchasingOrderD
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int DocNo { get; set; }
        public string ProdName { get; set; }
        public string Unit { get; set; }
        public string Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string UnitTotal { get; set; }
        public string SalesTax { get; set; }
        public string Discount { get; set; }
        public string TotalPrice { get; set; }
    }
}
