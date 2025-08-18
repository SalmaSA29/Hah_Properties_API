using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprBoqCostD
    {
        public string ProjectId { get; set; }
        public string TypeOfWorkId { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double Qty { get; set; }
        public double UnitCost { get; set; }
        public double Total { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual TprBoqCostM TprBoqCostM { get; set; }
    }
}
