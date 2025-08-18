using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanDiscipline
    {
        public int DiscId { get; set; }
        public string DiscName { get; set; }
        public string DiscDesc { get; set; }
        public string DiscInUser { get; set; }
        public DateTime? DiscInDate { get; set; }
        public string DiscUpUser { get; set; }
        public DateTime? DiscUpDate { get; set; }
    }
}
