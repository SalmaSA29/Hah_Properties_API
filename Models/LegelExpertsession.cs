using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class LegelExpertsession
    {
        public int SexpId { get; set; }
        public string AffairNo { get; set; }
        public DateTime? SessionDate { get; set; }
        public string Decision { get; set; }
        public string Notes { get; set; }
        public string Expertno { get; set; }
        public int? ExpertofficeId { get; set; }
        public string Expertmanname { get; set; }
        public string Reasonofsession { get; set; }
        public int? LawyerId { get; set; }
        public DateTime? NextSessionDate { get; set; }
        public string Floor { get; set; }
        public string Inuser { get; set; }
        public DateTime? Indate { get; set; }
        public string Upuser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
