using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprExpedPlanM
    {
        public TprExpedPlanM()
        {
            TprExpedPlanComments = new HashSet<TprExpedPlanComments>();
            TprExpedPlanD = new HashSet<TprExpedPlanD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public DateTime Date { get; set; }
        public string AggrementName { get; set; }
        public string Descrp { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public bool? Submit { get; set; }
        public bool? Approved { get; set; }
        public bool? Ignore { get; set; }
        public bool? Back { get; set; }
        public string BackReson { get; set; }
        public DateTime? AwardingPlanDate { get; set; }
        public bool? Manual { get; set; }

        public virtual ICollection<TprExpedPlanComments> TprExpedPlanComments { get; set; }
        public virtual ICollection<TprExpedPlanD> TprExpedPlanD { get; set; }
    }
}
