using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfGetHrcode
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string HrCode { get; set; }
        public DateTime? InDate { get; set; }
    }
}
