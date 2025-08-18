using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class BimElevation
    {
        public int ElevId { get; set; }
        public string Elevname { get; set; }
        public int? ProjectId { get; set; }
        public int? ParcelId { get; set; }
        public int? BuildingId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
