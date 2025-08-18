using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingItems
    {
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public int? ItemCount { get; set; }
        public string ItemUnit { get; set; }
        public string ItemCoding { get; set; }
        public string ItemNameAr { get; set; }
        public string AssetCode { get; set; }
    }
}
