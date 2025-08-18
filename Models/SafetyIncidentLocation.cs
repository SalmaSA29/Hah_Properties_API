using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SafetyIncidentLocation
    {
        public int IncLocId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Workplace { get; set; }
        public string Officeimpacted { get; set; }
        public string Linemanager { get; set; }
        public string Witnessname { get; set; }
    }
}
