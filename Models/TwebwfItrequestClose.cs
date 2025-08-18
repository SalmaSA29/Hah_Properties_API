using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItrequestClose
    {
        public int ClId { get; set; }
        public string ClService { get; set; }
        public int? ClRequestNo { get; set; }
        public string ClToEmail { get; set; }
        public string ClBody { get; set; }
    }
}
