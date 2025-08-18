using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprBoqD
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string ItemNo { get; set; }
        public string ParentItem { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double Qty { get; set; }
        public double? QtyOut { get; set; }
        public double Remain { get; set; }
        public double UnitCost { get; set; }
        public double Total { get; set; }
        public string Comments { get; set; }
        public string TypeOfWorkId { get; set; }
        public string CcWorkPackageId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual TprBoqM TprBoqM { get; set; }
        public virtual TprTypeOfWork TypeOfWork { get; set; }
    }
}
