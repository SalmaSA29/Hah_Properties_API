using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanActualDateD
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public DateTime? SubmitalDate { get; set; }
        public DateTime? SubmitalReplay { get; set; }
        public string Comments { get; set; }

        public virtual TprPlanActualDateM Project { get; set; }
    }
}
