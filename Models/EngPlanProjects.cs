using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanProjects
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? ClientId { get; set; }
        public int? ConsultantId { get; set; }
        public double? ProjectValue { get; set; }
        public int? Duration { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUser { get; set; }
    }
}
