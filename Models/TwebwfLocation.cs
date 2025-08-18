using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfLocation
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string DirectorUserHrCode { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public int? OldLocationId { get; set; }
        public string OldLocationName { get; set; }
        public int? NewProjectCode { get; set; }
    }
}
