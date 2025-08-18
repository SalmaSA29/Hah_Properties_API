using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebWfEmpEducation
    {
        public string UserHrCode { get; set; }
        public int RecordId { get; set; }
        public string University { get; set; }
        public string Collage { get; set; }
        public string Category { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
