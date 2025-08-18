using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlaneFloor
    {
        public int FlId { get; set; }
        public string FlName { get; set; }
        public string FlDesc { get; set; }
        public string FlInUser { get; set; }
        public DateTime? FlInDate { get; set; }
        public string FlUpUser { get; set; }
        public DateTime? FlUpDate { get; set; }
    }
}
