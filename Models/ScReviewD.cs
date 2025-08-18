using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScReviewD
    {
        public string DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int AgreementNo { get; set; }
        public string ItemNo { get; set; }
        public double? AgreementQty { get; set; }
        public double? RequestedQty { get; set; }
        public double? DoneByHac { get; set; }
        public double? SubToClient { get; set; }
        public double? ApprovedByClient { get; set; }
        public double? PaidByClient { get; set; }
        public double? SubPercent { get; set; }
        public double? AppPercent { get; set; }
        public double? PaidPercent { get; set; }
        public double? ScProgress { get; set; }
        public double? ScSubQty { get; set; }
        public double? ScAppQty { get; set; }
        public double? ScPaidQty { get; set; }
        public double? BalanceQty { get; set; }

        public virtual ScReviewM ScReviewM { get; set; }
    }
}
