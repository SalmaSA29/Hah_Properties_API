using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstNewAgreementAddendumD
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string ItemNo { get; set; }
        public string SupplierId { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double Qty { get; set; }
        public double UnitBudget { get; set; }
        public double TotalBudget { get; set; }
        public double AggQty { get; set; }
        public double AggUnitCost { get; set; }
        public double AggTotalCost { get; set; }
        public string BoqItem { get; set; }
        public string BoqItemId { get; set; }
        public string DivisionId { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstNewAgreementAddendumM CstNewAgreementAddendumM { get; set; }
    }
}
