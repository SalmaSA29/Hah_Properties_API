using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnVendorPaymentD
    {
        public string DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public string AgreementNo { get; set; }
        public string ItemNo { get; set; }
        public string Unit { get; set; }
        public double? Qty { get; set; }
        public double? UnitBudget { get; set; }
        public double? TotalBudget { get; set; }
        public double? ReqQty { get; set; }
        public double? TotalReq { get; set; }
        public double? DoneByHac { get; set; }
        public double? SubQtyCost { get; set; }
        public double? AppQtyCost { get; set; }
        public double? PaidByClient { get; set; }
        public double? SubPerc { get; set; }
        public double? AppPerc { get; set; }
        public double? PaidPerc { get; set; }
        public double? ExecutedByScUnit { get; set; }
        public double? ScSubQty { get; set; }
        public double? ScAppQty { get; set; }
        public double? ScPaidQty { get; set; }
        public double? BalanceQty { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string AgrrementType { get; set; }
        public double? ActualWd { get; set; }
        public double? Paid { get; set; }
        public double? ApprovedByClient { get; set; }
        public double? SubmittedToClient { get; set; }
        public double? RequiredBySite { get; set; }

        public virtual CstnVendorPaymentM CstnVendorPaymentM { get; set; }
    }
}
