using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TpettyD
    {
        public int DocNo { get; set; }
        public int RecordId { get; set; }
        public string Serial { get; set; }
        public DateTime Date { get; set; }
        public string CostDesc { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string CostType { get; set; }
        public string CostId { get; set; }
        public double Value { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual Tcost Cost { get; set; }
        public virtual TpettyM DocNoNavigation { get; set; }
    }
}
