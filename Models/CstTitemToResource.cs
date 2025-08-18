using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTitemToResource
    {
        public string ItemNo { get; set; }
        public string TaskId { get; set; }
        public string ResourceId { get; set; }
        public int RecordId { get; set; }
        public string Unit { get; set; }
        public double ResourceQtyPerTaskUnit { get; set; }
        public double? ResourceQty { get; set; }
        public double UnitCost { get; set; }
        public double? Depreciation { get; set; }
        public double? TotalCost { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstTitemToTask CstTitemToTask { get; set; }
    }
}
