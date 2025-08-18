using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoStockOutD
    {
        public int DocNo { get; set; }
        public int StockId { get; set; }
        public string ItemId { get; set; }
        public int UnitId { get; set; }
        public double Qty { get; set; }
        public string Comments { get; set; }

        public virtual RoTitem Item { get; set; }
        public virtual RoStocOutM RoStocOutM { get; set; }
        public virtual RoTunitType Unit { get; set; }
    }
}
