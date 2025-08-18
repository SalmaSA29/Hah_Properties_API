using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItincidentImpactService
    {
        public int SerId { get; set; }
        public int? IncId { get; set; }
        public string SerServiceDesc { get; set; }
        public string SerOwner { get; set; }
        public string SerBusImpact { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }

        public virtual ItincidentM Inc { get; set; }
    }
}
