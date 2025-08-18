using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstVendorPaymentD
    {
        public string DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public string ItemNo { get; set; }
        public string Unit { get; set; }
        public double Qty { get; set; }
        public double? UnitCost { get; set; }
        public double? TotalCost { get; set; }
        public double? ReqQty { get; set; }
        public double? TotalReq { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstVendorPaymentM CstVendorPaymentM { get; set; }
    }
}
