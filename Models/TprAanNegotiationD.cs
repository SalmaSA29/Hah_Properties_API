using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprAanNegotiationD
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public int DocNo { get; set; }
        public string SupplierId1 { get; set; }
        public bool? VendorList { get; set; }
        public double? QuotedPrice { get; set; }
        public double? FinalPrice { get; set; }
        public double? VarianceAmount { get; set; }
        public double? VariancePrecentage { get; set; }
        public double? QuotedDelivery { get; set; }
        public double? FinalDelivery { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual TprAanApproval TprAanApproval { get; set; }
    }
}
