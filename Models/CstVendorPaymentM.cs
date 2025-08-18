using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstVendorPaymentM
    {
        public CstVendorPaymentM()
        {
            CstVendorPaymentD = new HashSet<CstVendorPaymentD>();
        }

        public string DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public string AgreementNo { get; set; }
        public DateTime? Date { get; set; }
        public double? Labor { get; set; }
        public double? Material { get; set; }
        public double? Equipment { get; set; }
        public double? Other { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<CstVendorPaymentD> CstVendorPaymentD { get; set; }
    }
}
