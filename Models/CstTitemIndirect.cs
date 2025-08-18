using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTitemIndirect
    {
        public CstTitemIndirect()
        {
            CstTitemIndirectResource = new HashSet<CstTitemIndirectResource>();
        }

        public int RecordId { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string ItemUnit { get; set; }
        public double? Qty { get; set; }
        public double? UnitCost { get; set; }
        public double? TotalCost { get; set; }
        public double? Duration { get; set; }
        public double? Desperation { get; set; }
        public double? Wastage { get; set; }
        public string DivisionId { get; set; }
        public string WorkPackageId { get; set; }
        public string ProjectId { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CstTitemIndirectResource> CstTitemIndirectResource { get; set; }
    }
}
