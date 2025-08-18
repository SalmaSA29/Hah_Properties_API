using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTitem
    {
        public int RecordId { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double? OrgQty { get; set; }
        public double? OrgUnitCost { get; set; }
        public double? OrgUnitSelling { get; set; }
        public double? OrgTotalCost { get; set; }
        public double? OrgTotalSelling { get; set; }
        public string WorkPackageId { get; set; }
        public string MainTradeId { get; set; }
        public string TradeId { get; set; }
        public string DivisionId { get; set; }
        public string ProjectId { get; set; }
        public int? ItemType { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public bool? Select { get; set; }
    }
}
