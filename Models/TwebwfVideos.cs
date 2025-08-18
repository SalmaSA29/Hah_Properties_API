using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfVideos
    {
        public int Id { get; set; }
        public string VideoName { get; set; }
        public bool? IsMain { get; set; }
        public bool? IsPortal { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
