using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TworkPackageProjet
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public DateTime? PlanningDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public int? Weight { get; set; }
        public int? ManHour { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual Tproject Project { get; set; }
    }
}
