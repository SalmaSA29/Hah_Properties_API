using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScReviewM
    {
        public ScReviewM()
        {
            ScReviewD = new HashSet<ScReviewD>();
        }

        public string DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int AgreementNo { get; set; }
        public DateTime? Date { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<ScReviewD> ScReviewD { get; set; }
    }
}
