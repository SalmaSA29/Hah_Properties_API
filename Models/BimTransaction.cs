using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class BimTransaction
    {
        public int TransId { get; set; }
        public DateTime? TransDate { get; set; }
        public int? ProjectId { get; set; }
        public int? ParcelId { get; set; }
        public int? BuildingId { get; set; }
        public int? PartId { get; set; }
        public int? FloorId { get; set; }
        public int? EffortSpecify3Id { get; set; }
        public int? EffortSpecify2Id { get; set; }
        public int? EffortSpecifyId { get; set; }
        public int? EffortId { get; set; }
        public int? ManHour { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public int? LevelId { get; set; }
        public int? ElevId { get; set; }
        public string SheetName { get; set; }
        public string TotalProgress { get; set; }
    }
}
