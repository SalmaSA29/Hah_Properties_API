using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class BimEffortSpecify3
    {
        public int EffortSpecify3Id { get; set; }
        public string EffortSpecify3Name { get; set; }
        public int? EffortSpecify2Id { get; set; }
        public int? ProjectId { get; set; }
        public string InUser { get; set; }
        public DateTime? EffortSpecifyDate { get; set; }
        public int? FloorId { get; set; }
        public int? PartId { get; set; }
        public int? EffortId { get; set; }
        public int? EffortSpecifyId { get; set; }
    }
}
