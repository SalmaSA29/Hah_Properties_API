using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingPtM
    {
        public int PtId { get; set; }
        public DateTime? PtDate { get; set; }
        public int? ProjectId { get; set; }
        public int? MrId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
