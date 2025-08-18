using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecProjectBudget
    {
        public int ProjectId { get; set; }
        public int? Budget18 { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
