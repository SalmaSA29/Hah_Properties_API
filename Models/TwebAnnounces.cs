using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebAnnounces
    {
        public int AnnounceId { get; set; }
        public string AnnounceTitle { get; set; }
        public string AnnounceBody { get; set; }
        public string AnnounceTitleAr { get; set; }
        public string AnnounceBodyAr { get; set; }
        public DateTime? AnnounceDate { get; set; }
        public int? Findex { get; set; }
    }
}
