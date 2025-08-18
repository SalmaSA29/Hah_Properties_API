using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TndrProjectInformationDetail
    {
        public string ProjectId { get; set; }
        public DateTime? TenderClosingDate { get; set; }
        public string SiteVisitPreTenderMeeting { get; set; }
        public DateTime? LastDateOfQueries { get; set; }
        public DateTime? TenderValidity { get; set; }
        public string TenderBond { get; set; }
        public string TenderBondValidity { get; set; }
        public string TypeOfContract { get; set; }
        public DateTime? TimeForCompletion { get; set; }
        public string DefectsLiabilityPeriod { get; set; }
        public string AdvancePayment { get; set; }
        public string AdvancePaymentRepaymentTerms { get; set; }
        public string InterimPayments { get; set; }
    }
}
