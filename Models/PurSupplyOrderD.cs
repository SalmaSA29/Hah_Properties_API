using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PurSupplyOrderD
    {
        public int DocNo { get; set; }
        public string SupplierId { get; set; }
        public string ItemNo { get; set; }
        public string Unit { get; set; }
        public double Qty { get; set; }
        public double Price { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual PurSupplyOrderM PurSupplyOrderM { get; set; }
    }
}
