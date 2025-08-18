using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingQuotationD
    {
        public int RecordId { get; set; }
        public int? MrId { get; set; }
        public double? SupplierId { get; set; }
        public int? ProjectId { get; set; }
        public string ItemCode { get; set; }
        public string Unit { get; set; }
        public double? UnitPrice { get; set; }
        public double? Qty { get; set; }
        public double? Discount { get; set; }
        public double? Total { get; set; }
        public double? SalesTaxPerc { get; set; }
        public double? SalesTax { get; set; }
        public double? SumTotal { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public int? RfqSerial { get; set; }
        public double? DiscountPerc { get; set; }
        public double? DiscountValue { get; set; }
        public double? GenTotal { get; set; }
        public double? Vat { get; set; }
        public double? Vatvalue { get; set; }
    }
}
