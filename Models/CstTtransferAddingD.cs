using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTtransferAddingD
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string AreaNo { get; set; }
        public string ResourceId { get; set; }
        public double TransQty { get; set; }
        public double UnitCost { get; set; }
        public double? TransAmount { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstTtransferM CstTtransferM { get; set; }
    }
}
