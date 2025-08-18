using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PurchasingOrderItemsD
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int DocNo { get; set; }
        public string ItemNo { get; set; }
        public string Area { get; set; }
        public string ResourceId { get; set; }
        public string QtyRequested { get; set; }
        public string Status { get; set; }
        public string BudgetQty { get; set; }
        public string QtyRef { get; set; }
        public string Rcvd { get; set; }
        public string IssuedForOthers { get; set; }
        public string AllowedBudgetTodate { get; set; }
        public string Variance { get; set; }
    }
}
