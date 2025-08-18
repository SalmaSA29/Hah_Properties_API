using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ManPowerBudget
    {
        public int BgId { get; set; }
        public int AsId { get; set; }
        public int? ProjectId { get; set; }
        public int? SapId { get; set; }
        public DateTime? BgMonth { get; set; }
        public int? BgHeadCount { get; set; }
        public string BgInUser { get; set; }
        public DateTime? BgInDate { get; set; }
        public string BgUpUser { get; set; }
        public DateTime? BgUpDate { get; set; }
    }
}
