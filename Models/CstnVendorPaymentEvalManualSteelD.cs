using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnVendorPaymentEvalManualSteelD
    {
        public string DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public string AgreementNo { get; set; }
        public int ParamterId { get; set; }
        public bool? UnAcceptable { get; set; }
        public bool? Poor { get; set; }
        public bool? BelowAverage { get; set; }
        public bool? Average { get; set; }
        public bool? AboveAverage { get; set; }
        public bool? Ideal { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual CstnVendorPaymentManualSteelM CstnVendorPaymentManualSteelM { get; set; }
    }
}
