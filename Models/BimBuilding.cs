using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class BimBuilding
    {
        public int BuildingId { get; set; }
        public string BuildingName { get; set; }
        public int? ParcelId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
    }
}
