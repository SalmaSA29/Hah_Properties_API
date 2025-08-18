using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanZone
    {
        public int ZoId { get; set; }
        public string ZoName { get; set; }
        public string ZoDesc { get; set; }
        public string ZoInUser { get; set; }
        public DateTime? ZoInDate { get; set; }
        public string ZoUpUser { get; set; }
        public DateTime? ZoUpDate { get; set; }
    }
}
