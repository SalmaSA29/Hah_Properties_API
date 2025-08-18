using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnPfrD
    {
        public string ProjectId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string CostId { get; set; }
        public string PfrNo { get; set; }
        public decimal Forecast { get; set; }
        public decimal? CurrentBudget { get; set; }
        public string Comments { get; set; }

        public virtual CstnPfrM CstnPfrM { get; set; }
    }
}
