using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class InternalMeetingDocs
    {
        public int DocId { get; set; }
        public int? ClassId { get; set; }
        public int? ProjId { get; set; }
        public int? FoulderId { get; set; }
        public string DocName { get; set; }
        public string DocAttached { get; set; }
        public string Inuser { get; set; }
        public DateTime? InDate { get; set; }
        public string Upuser { get; set; }
        public DateTime? Updateuser { get; set; }
    }
}
