using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PurTlocalPurchaseOrderM
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? MrReceivedDate { get; set; }
        public string SupplierId { get; set; }
        public DateTime? PoDate { get; set; }
        public string PoDocNo { get; set; }
        public string Address { get; set; }
        public string Duration { get; set; }
        public string Payment { get; set; }
        public string Comments { get; set; }
        public double? Value { get; set; }
        public double? TxAddPerc { get; set; }
        public double? TaxDecPer { get; set; }
        public double? TaxAdd { get; set; }
        public double? TaxDec { get; set; }
        public double? Total { get; set; }
    }
}
