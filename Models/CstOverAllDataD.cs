using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstOverAllDataD
    {
        public string ProjectId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal? PlannedWorkValue { get; set; }
        public decimal? PlannedProgress { get; set; }
        public decimal? ActualProgress { get; set; }
        public decimal? CashIn { get; set; }
        public decimal? CashOut { get; set; }
        public string Comments { get; set; }

        public virtual CstOverAllDataM Project { get; set; }
    }
}
