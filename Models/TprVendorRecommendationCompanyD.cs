using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprVendorRecommendationCompanyD
    {
        public int RecordId { get; set; }
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public bool? RecReq { get; set; }
        public bool? ForNeg { get; set; }
        public bool? OnlyRfq { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public string Comments { get; set; }

        public virtual TprVendorRecommendationM TprVendorRecommendationM { get; set; }
    }
}
