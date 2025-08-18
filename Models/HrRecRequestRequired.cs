using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecRequestRequired
    {
        public int RequestId { get; set; }
        public int? GroupId { get; set; }
        public int? InterviewId { get; set; }
        public int? LocationId { get; set; }
        public int? JobId { get; set; }
        public string Major { get; set; }
        public string UserHrCode { get; set; }
        public DateTime? InDate { get; set; }
        public bool? Done { get; set; }
    }
}
