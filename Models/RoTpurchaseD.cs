using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoTpurchaseD
    {
        public int DocNo { get; set; }
        public int StockId { get; set; }
        public string ItemId { get; set; }
        public int UnitId { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public double UnitPrice { get; set; }
        public double TotalDisc { get; set; }
        public double Final { get; set; }
        public string Comments { get; set; }

        public virtual RoTitem Item { get; set; }
        public virtual RoTpurchaseM RoTpurchaseM { get; set; }
        public virtual RoTunitType Unit { get; set; }
    }
}
