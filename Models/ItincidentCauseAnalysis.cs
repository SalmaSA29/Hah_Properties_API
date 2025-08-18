using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItincidentCauseAnalysis
    {
        public int CaId { get; set; }
        public int? IncId { get; set; }
        public string CaProcedures { get; set; }
        public string CaOwner { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }

        public virtual ItincidentM Inc { get; set; }
    }
}
