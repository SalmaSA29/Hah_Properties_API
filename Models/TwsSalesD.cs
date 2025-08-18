using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsSalesD
    {
        public string StockId { get; set; }
        public string DocNo { get; set; }
        public string ItemId { get; set; }
        public string FiscalYear { get; set; }
        public double? Qty { get; set; }
        public double? UnitPrice { get; set; }
        public double? Value { get; set; }
        public double? TaxSalesPerc { get; set; }
        public double? Total { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool? UsedItem { get; set; }
        public DateTime? LastDateIssue { get; set; }
        public string LastJobOrder { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public double? TaxSales { get; set; }

        public virtual TwsItem Item { get; set; }
        public virtual TwsSalesM TwsSalesM { get; set; }
    }
}
