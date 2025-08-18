using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstCompanyPerformanceD
    {
        public string ProjectId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal? ApprovedAmount { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public decimal? WorkDone { get; set; }
        public decimal? SubmittedAmount { get; set; }
        public DateTime? DateOfSubmission { get; set; }
        public DateTime? PaidPaid { get; set; }
        public DateTime? CutOfdate { get; set; }
        public decimal? PlannedWorkValue { get; set; }
        public decimal? PlannedProgress { get; set; }
        public decimal? ActualProgress { get; set; }
        public decimal? CashIn { get; set; }
        public decimal? CashOut { get; set; }
        public decimal? ForeCastWorkValue { get; set; }
        public double? StaffBudget { get; set; }
        public double? LaborBudget { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual CstCompanyPerformanceM CstCompanyPerformanceM { get; set; }
    }
}
