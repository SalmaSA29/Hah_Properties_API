using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsBStock
    {
        public string FiscalYear { get; set; }
        public string ItemId { get; set; }
        public string StockId { get; set; }
        public double? Qty { get; set; }
        public double? UnitPrice { get; set; }
        public double Value { get; set; }
        public double? TaxSalesPerc { get; set; }
        public double? TaxSales { get; set; }
        public double? Total { get; set; }
    }
}
