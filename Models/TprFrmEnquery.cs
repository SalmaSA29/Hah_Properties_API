using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprFrmEnquery
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public DateTime? Date { get; set; }
        public string PurchasingOrder { get; set; }
        public bool? VendorRecommendationRequest { get; set; }
        public bool? MakeOrBuy { get; set; }
        public bool? UpDatingTbeForm { get; set; }
        public bool? RegretLetter { get; set; }
        public bool? LetterOfIntent { get; set; }
        public bool? LcRequest { get; set; }
        public bool? AdvancePaymentApproval { get; set; }
        public DateTime? StartDate { get; set; }
        public string OnSite { get; set; }
        public string ManufacturingPeriod { get; set; }
        public bool? RelatedMileStonesWithLd { get; set; }
        public byte? ContractType { get; set; }
        public string ProposedFormToBeUsed { get; set; }
        public string Remarks { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
