using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnVendorPaymentManualD
    {
        public int RecordId { get; set; }
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public string AgreementNo { get; set; }
        public string ItemNo { get; set; }
        public string AgrrementType { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double? Qty { get; set; }
        public double? UnitBudget { get; set; }
        public double? TotalBudget { get; set; }
        public double? ReqQty { get; set; }
        public double? UnitOffer { get; set; }
        public double? TotalReq { get; set; }
        public double? ContractValue { get; set; }
        public double? Bcwp { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstnVendorPaymentManualM CstnVendorPaymentManualM { get; set; }
    }
}
