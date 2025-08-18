using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingTqD
    {
        public int TqDId { get; set; }
        public int? TqId { get; set; }
        public int? MrId { get; set; }
        public int? ItemCode { get; set; }
        public int? Qty { get; set; }
        public string ItemUnit { get; set; }
    }
}
