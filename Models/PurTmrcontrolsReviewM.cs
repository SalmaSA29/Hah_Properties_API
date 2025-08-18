using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PurTmrcontrolsReviewM
    {
        public PurTmrcontrolsReviewM()
        {
            PurTmrcontrolsReviewD = new HashSet<PurTmrcontrolsReviewD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? MrReceivedDate { get; set; }

        public virtual ICollection<PurTmrcontrolsReviewD> PurTmrcontrolsReviewD { get; set; }
    }
}
