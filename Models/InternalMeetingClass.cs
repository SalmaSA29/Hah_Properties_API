using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class InternalMeetingClass
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string Inuser { get; set; }
        public DateTime? InDate { get; set; }
        public string Upuser { get; set; }
        public DateTime? Updateuser { get; set; }
    }
}
