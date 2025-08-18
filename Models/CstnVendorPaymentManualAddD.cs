using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnVendorPaymentManualAddD
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public string AgreementNo { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string ConstructionCategoryId { get; set; }
        public string CostId { get; set; }

        public virtual CstnVendorPaymentManualM CstnVendorPaymentManualM { get; set; }
    }
}
