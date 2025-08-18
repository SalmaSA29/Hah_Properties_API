using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstBudgetVoInDirectD
    {
        public int RecordId { get; set; }
        public int DocNo { get; set; }
        public string ItemNo { get; set; }
        public string ProjectId { get; set; }
        public string ResourceId { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string DivisionId { get; set; }
        public double? ConQty { get; set; }
        public double? UnitCost { get; set; }
        public double? ResourceOutput { get; set; }
        public double? Wastage { get; set; }
        public double? ResourceUnitCost { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstBudgetVoM CstBudgetVoM { get; set; }
    }
}
