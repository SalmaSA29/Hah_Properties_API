using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PurTmrcontrolsReviewD
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string ExpType { get; set; }
        public double? BudgetToDate { get; set; }
        public double? BudgetToCompletion { get; set; }
        public double? ExpendedToDate { get; set; }
        public double? Forecast { get; set; }
        public double? BudgetToDateVariance { get; set; }
        public double? BudgetToCompletionVariance { get; set; }
        public string Comments { get; set; }

        public virtual PurTmrcontrolsReviewM PurTmrcontrolsReviewM { get; set; }
    }
}
