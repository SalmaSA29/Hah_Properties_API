using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PurTlocalPurchaseOrderD
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double Qty { get; set; }
        public double UnitPrice { get; set; }
        public double Value { get; set; }
        public double? BudgetQty { get; set; }
        public double? QtyRef { get; set; }
        public double? Rcved { get; set; }
        public double? IssuedForOthers { get; set; }
        public double? AllowedBudgetToDate { get; set; }
        public double? Variance { get; set; }
        public string Comments { get; set; }
    }
}
