using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TalentUsers
    {
        public int UserId { get; set; }
        public string UserHrcode { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public bool? TalentTeaam { get; set; }
        public bool? Technicalteem { get; set; }
        public bool? FinalEdit { get; set; }
        public string AssestHrCode { get; set; }
    }
}
