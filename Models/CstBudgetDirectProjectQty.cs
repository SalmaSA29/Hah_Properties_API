using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstBudgetDirectProjectQty
    {
        public string ItemNo { get; set; }
        public string ProjectId { get; set; }
        public double? RevQty { get; set; }
        public double? SubQty { get; set; }
        public double? AppQty { get; set; }
        public double? EstQtyCost { get; set; }
        public double? RevQtyCost { get; set; }
        public double? SubQtyCost { get; set; }
        public double? AppQtyCost { get; set; }
        public double? EstQtySelling { get; set; }
        public double? RevQtySelling { get; set; }
        public double? SubQtySelling { get; set; }
        public double? AppQtySelling { get; set; }
        public string Comments { get; set; }
        public double? UnitCost { get; set; }
        public double? UnitSelling { get; set; }
        public double? ConQty { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
