using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecJobApply
    {
        public int AppId { get; set; }
        public int? JobId { get; set; }
        public int? MajorId { get; set; }
        public int? SeekerId { get; set; }
        public DateTime? InDate { get; set; }
    }
}
