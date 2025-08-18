using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTitemIndirectPeriods
    {
        public int RecordId { get; set; }
        public string ItemNo { get; set; }
        public string ResourceId { get; set; }
        public int FromPeriod { get; set; }
        public int ToPeriod { get; set; }
        public double Qty { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
