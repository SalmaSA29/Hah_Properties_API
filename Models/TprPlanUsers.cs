using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanUsers
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string UserId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public string Comments { get; set; }

        public virtual TprPlan TprPlan { get; set; }
    }
}
