using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprComparisonQuotedItemsNegotiationD
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string ItemNo { get; set; }
        public string Unit { get; set; }
        public double? Qty { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public string Comments { get; set; }

        public virtual TprComparisonNegotiationM TprComparisonNegotiationM { get; set; }
    }
}
