using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTitemToTask
    {
        public CstTitemToTask()
        {
            CstTitemToResource = new HashSet<CstTitemToResource>();
        }

        public string ItemNo { get; set; }
        public string TaskId { get; set; }
        public string ProjectId { get; set; }
        public string Unit { get; set; }
        public double TaskQtyPerItemUnit { get; set; }
        public double Qty { get; set; }
        public double? UnitCost { get; set; }
        public double? TotalCost { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CstTitemToResource> CstTitemToResource { get; set; }
    }
}
