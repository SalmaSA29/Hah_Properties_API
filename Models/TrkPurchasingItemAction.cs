using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingItemAction
    {
        public int ItemActionId { get; set; }
        public int? MrDet { get; set; }
        public string ItemCode { get; set; }
        public int? ItemCount { get; set; }
        public int? Status { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public int? MrId { get; set; }
        public string ItemComment { get; set; }
    }
}
