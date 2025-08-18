using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class AcomProjectBudget
    {
        public string ProjectId { get; set; }
        public double? TotalBudget { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CurrentDurationInMonth { get; set; }
        public double? CurrentCost { get; set; }
        public double? RemainingCost { get; set; }
        public string Comments { get; set; }
    }
}
