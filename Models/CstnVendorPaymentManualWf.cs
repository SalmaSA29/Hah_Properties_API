using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnVendorPaymentManualWf
    {
        public int RecordId { get; set; }
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public string AgreementNo { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string UserId { get; set; }
        public int? StepNo { get; set; }
        public string Comments { get; set; }

        public virtual CstnVendorPaymentManualM CstnVendorPaymentManualM { get; set; }
    }
}
