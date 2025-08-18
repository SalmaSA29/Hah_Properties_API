using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprVendorRecommendationEvalD
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int ParamterId { get; set; }
        public int? Weight { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual TprVendorRecommendationM TprVendorRecommendationM { get; set; }
    }
}
