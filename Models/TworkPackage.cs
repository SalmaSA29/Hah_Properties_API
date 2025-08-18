using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TworkPackage
    {
        public string WorkPackageId { get; set; }
        public string WorkPackage { get; set; }
        public string DisciplineCode { get; set; }
        public string WorkGroupId { get; set; }
        public string WorkTypeId { get; set; }
        public string NewName { get; set; }
        public string DisciplineCodeNew { get; set; }
        public string NewCode { get; set; }
        public double? AdPaymentIdTeam { get; set; }
        public double? AdPaymentIdManager { get; set; }
        public double? RetentionIdTeam { get; set; }
        public double? RetentionIdManager { get; set; }
        public double? PaymentsondeliveryIdTeam { get; set; }
        public double? PaymentsondeliveryIdManager { get; set; }
        public bool? LongLeadItem { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public double? High { get; set; }
        public double? MedHigh { get; set; }
        public double? Med { get; set; }
        public double? MedLow { get; set; }
        public double? Low { get; set; }
    }
}
