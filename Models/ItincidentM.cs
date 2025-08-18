using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItincidentM
    {
        public ItincidentM()
        {
            ItincidentCauseAnalysis = new HashSet<ItincidentCauseAnalysis>();
            ItincidentImpactService = new HashSet<ItincidentImpactService>();
            ItincidentRecommend = new HashSet<ItincidentRecommend>();
        }

        public int IncId { get; set; }
        public DateTime? IncEffDate { get; set; }
        public string IncDesc { get; set; }
        public DateTime? IncDateFrom { get; set; }
        public DateTime? IncDateTo { get; set; }
        public double? IncDuration { get; set; }
        public string IncReporter { get; set; }
        public string IncResponceTeam { get; set; }
        public string IncAnalysis { get; set; }
        public string IncProToSolve { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }

        public virtual ICollection<ItincidentCauseAnalysis> ItincidentCauseAnalysis { get; set; }
        public virtual ICollection<ItincidentImpactService> ItincidentImpactService { get; set; }
        public virtual ICollection<ItincidentRecommend> ItincidentRecommend { get; set; }
    }
}
