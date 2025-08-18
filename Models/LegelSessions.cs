using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class LegelSessions
    {
        public int Sid { get; set; }
        public string AffairNo { get; set; }
        public DateTime? SessionDate { get; set; }
        public DateTime? NextSessionDate { get; set; }
        public DateTime? PreviousSessioDate { get; set; }
        public string Requirement { get; set; }
        public string Decision { get; set; }
        public string Notes { get; set; }
        public string Inuser { get; set; }
        public DateTime? Indate { get; set; }
        public string Upuser { get; set; }
        public DateTime? UpDate { get; set; }
        public int? LawyerId { get; set; }
    }
}
