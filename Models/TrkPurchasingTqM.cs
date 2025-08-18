using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingTqM
    {
        public int TqId { get; set; }
        public DateTime? TqDate { get; set; }
        public int? ProjectId { get; set; }
        public int? MrId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
