using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingItemInMr
    {
        public int ItemCode { get; set; }
        public int MrId { get; set; }
        public int? ItemCount { get; set; }
        public string ItemName { get; set; }
        public string ItemUnit { get; set; }
        public string ItemComment { get; set; }
        public int? TotalBeforeCount { get; set; }
        public int? TotalProjectCount { get; set; }
    }
}
