using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanLongLeadD
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string ItemNo { get; set; }
        public string ItemName { get; set; }
        public DateTime? MaterialOnSiteDateForItem { get; set; }
        public DateTime? POIssuingDatePln { get; set; }
        public DateTime? POIssuingDateAct { get; set; }
        public DateTime? AdvancePaymentOrLgPln { get; set; }
        public DateTime? AdvancePaymentOrLgAct { get; set; }
        public DateTime? TechnicalSubmittalToConsultantPln { get; set; }
        public DateTime? TechnicalSubmittalToConsultantAct { get; set; }
        public DateTime? TechnicalSubmittalApprovalPln { get; set; }
        public DateTime? TechnicalSubmittalApprovalAct { get; set; }
        public DateTime? StartFabricationDatePln { get; set; }
        public DateTime? StartFabricationDateAct { get; set; }
        public DateTime? InspectionPln { get; set; }
        public DateTime? InspectionAct { get; set; }
        public DateTime? StartDeliveryPln { get; set; }
        public DateTime? StartDeliveryAct { get; set; }
        public DateTime? MirFromConsultantPln { get; set; }
        public DateTime? MirFromConsultantAct { get; set; }
        public string Comments { get; set; }

        public virtual TprPlanLongLeadM TprPlanLongLeadM { get; set; }
    }
}
