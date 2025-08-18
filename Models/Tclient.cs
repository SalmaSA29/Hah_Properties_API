using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Tclient
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public double? Rank { get; set; }
        public bool? Owner { get; set; }
        public bool? Client { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
