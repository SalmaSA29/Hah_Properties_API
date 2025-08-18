using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnVendorPaymentLinksM
    {
        public CstnVendorPaymentLinksM()
        {
            CstnVendorPaymentLinksD = new HashSet<CstnVendorPaymentLinksD>();
        }

        public string DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public DateTime? Date { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<CstnVendorPaymentLinksD> CstnVendorPaymentLinksD { get; set; }
    }
}
