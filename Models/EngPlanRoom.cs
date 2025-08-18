using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanRoom
    {
        public int RoId { get; set; }
        public string RoName { get; set; }
        public string RoDesc { get; set; }
        public string RoInUser { get; set; }
        public DateTime? RoInDate { get; set; }
        public string RoUpUser { get; set; }
        public DateTime? RoUpDate { get; set; }
    }
}
