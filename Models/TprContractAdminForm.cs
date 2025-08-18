using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprContractAdminForm
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int DocNo { get; set; }
        public DateTime? Date { get; set; }
        public string MainScopeId { get; set; }
        public string PaymentTerms { get; set; }
        public double? Retenation { get; set; }
        public double? PerformanceBond { get; set; }
        public double? Adpayment { get; set; }
        public double? PerformanceBondVs { get; set; }
        public double? AdpaymentVs { get; set; }
    }
}
