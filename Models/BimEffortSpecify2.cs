using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class BimEffortSpecify2
    {
        public int EffortSpecify2Id { get; set; }
        public string EffortSpecify2Name { get; set; }
        public int? EffortSpecifyId { get; set; }
        public int? ProjectId { get; set; }
        public string InUser { get; set; }
        public DateTime? EffortSpecify2Date { get; set; }
        public int? FloorId { get; set; }
        public int? PartId { get; set; }
        public int? EffortId { get; set; }
    }
}
