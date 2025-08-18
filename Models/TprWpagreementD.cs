using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprWpagreementD
    {
        public int RecordId { get; set; }
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public decimal BQty { get; set; }
        public decimal Qty { get; set; }
        public decimal? UnitBudget { get; set; }
        public decimal? BTotal { get; set; }
        public decimal? TotalBudget { get; set; }
        public string BoqItem { get; set; }
        public string BoqItemId { get; set; }
        public string DivisionId { get; set; }
        public string CostId { get; set; }
        public string ItemResource { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public bool? Select { get; set; }

        public virtual TprWpagreementM TprWpagreementM { get; set; }
    }
}
