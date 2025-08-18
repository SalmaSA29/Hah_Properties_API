using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstSafetyEvaluation
    {
        public string ProjectId { get; set; }
        public DateTime? Date { get; set; }
        public double? EvalPerc { get; set; }
    }
}
