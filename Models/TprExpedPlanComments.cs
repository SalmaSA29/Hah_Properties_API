using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprExpedPlanComments
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int RecordId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UserComments { get; set; }

        public virtual TprExpedPlanM TprExpedPlanM { get; set; }
    }
}
