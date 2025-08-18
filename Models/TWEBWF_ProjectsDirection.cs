using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TWEBWF_ProjectsDirection
    {
        public int ID { get; set; }
        public int Project_ID { get; set; }
        public int? City_ID { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
    }
}
