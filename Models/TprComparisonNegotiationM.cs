using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprComparisonNegotiationM
    {
        public TprComparisonNegotiationM()
        {
            TprComparisonNegotiationSuppliersD = new HashSet<TprComparisonNegotiationSuppliersD>();
            TprComparisonQuotedItemsNegotiationD = new HashSet<TprComparisonQuotedItemsNegotiationD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public DateTime? Date { get; set; }
        public string Descrp { get; set; }
        public string TermsOfPayments { get; set; }
        public string LetterOfGuarantee { get; set; }
        public double? AdvancePayment { get; set; }
        public double? PaymentOnDelivery { get; set; }
        public double? Retenation { get; set; }
        public string Delivery { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual ICollection<TprComparisonNegotiationSuppliersD> TprComparisonNegotiationSuppliersD { get; set; }
        public virtual ICollection<TprComparisonQuotedItemsNegotiationD> TprComparisonQuotedItemsNegotiationD { get; set; }
    }
}
