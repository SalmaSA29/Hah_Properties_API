using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfRss
    {
        public int RssId { get; set; }
        public string RssTitle { get; set; }
        public string RssSubject { get; set; }
        public DateTime? RssInDate { get; set; }
        public string RssInUser { get; set; }
    }
}
