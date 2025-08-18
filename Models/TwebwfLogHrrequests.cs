using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfLogHrrequests
    {
        public int LogId { get; set; }
        public string ServiceId { get; set; }
        public int RequestNo { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public int? Status { get; set; }
    }
}
