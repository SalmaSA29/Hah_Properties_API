using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HahcodingInventoryItem
    {
        public string Division1 { get; set; }
        public string Division2 { get; set; }
        public string Division3 { get; set; }
        public string Division4 { get; set; }
        public string Division5 { get; set; }
        public string Division6 { get; set; }
        public string Division7 { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemSerial { get; set; }
        public int? Serial { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string MaterialTypes { get; set; }
        public string MatrialGroups { get; set; }
    }
}
