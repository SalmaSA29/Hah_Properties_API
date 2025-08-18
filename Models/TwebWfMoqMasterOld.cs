using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebWfMoqMasterOld
    {
        public int QmId { get; set; }
        public int? LocationId { get; set; }
        public DateTime? DateNo { get; set; }
        public bool? Active { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
