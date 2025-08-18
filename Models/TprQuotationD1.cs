using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprQuotationD1
    {
        public int RecordId { get; set; }
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public string ItemNo { get; set; }
        public string Unit { get; set; }
        public double BUnitPrice { get; set; }
        public double UnitPrice { get; set; }
        public double Qty { get; set; }
        public double? Discount { get; set; }
        public double? Val { get; set; }
        public double? SalesTaxPerc { get; set; }
        public double? SalesTax { get; set; }
        public double TotalCurr { get; set; }
        public double Total { get; set; }
        public double? PrevTotal { get; set; }
        public double? Variance { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string Description { get; set; }

        public virtual TprQuotationM TprQuotationM { get; set; }
    }
}
