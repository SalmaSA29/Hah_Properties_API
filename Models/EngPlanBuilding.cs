using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanBuilding
    {
        public int BuId { get; set; }
        public string BuName { get; set; }
        public string BuDesc { get; set; }
        public string BuInUser { get; set; }
        public DateTime? BuInDate { get; set; }
        public string BuUpUser { get; set; }
        public DateTime? BuUpDate { get; set; }
    }
}
