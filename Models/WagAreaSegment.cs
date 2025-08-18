using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagAreaSegment
    {
        public string ProjectId { get; set; }
        public string SegmentCode { get; set; }
        public string SegmentName { get; set; }
        public int? Serial { get; set; }
    }
}
