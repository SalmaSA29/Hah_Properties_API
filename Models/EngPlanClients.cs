using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanClients
    {
        public int ClientId { get; set; }
        public string Clientname { get; set; }
        public string ClientInUser { get; set; }
        public DateTime? ClientInDate { get; set; }
        public string ClientUpUser { get; set; }
        public DateTime? ClientUpdate { get; set; }
        public string ClientDesc { get; set; }
    }
}
