using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class BimFloor
    {
        public int FloorId { get; set; }
        public int? ParcelId { get; set; }
        public int? BuildingId { get; set; }
        public string FloorName { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? FloorDate { get; set; }
        public string InUser { get; set; }
    }
}
