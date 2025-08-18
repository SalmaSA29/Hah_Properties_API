using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanManualM
    {
        public TprPlanManualM()
        {
            TprPlanManualD = new HashSet<TprPlanManualD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string TeamLeaderUserId { get; set; }
        public string EngineerUserId { get; set; }
        public string SupplierId { get; set; }
        public DateTime Date { get; set; }
        public string AggrementName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public int? AgreementNo { get; set; }

        public virtual ICollection<TprPlanManualD> TprPlanManualD { get; set; }
    }
}
