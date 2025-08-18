using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTtransferArea
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public int RecordId { get; set; }
        public int? AreaNo { get; set; }
        public string ResourceId { get; set; }
        public double? CurrentQty { get; set; }
        public double? UnitCost { get; set; }
        public double? CurrentAmount { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstTtransferM CstTtransferM { get; set; }
    }
}
