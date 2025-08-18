using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class BimEffort
    {
        public int EffortId { get; set; }
        public string EffortName { get; set; }
        public int? PartId { get; set; }
        public int? ProjectId { get; set; }
        public string InUser { get; set; }
        public DateTime? EffortDate { get; set; }
        public int? FloorId { get; set; }
        public int? ElevId { get; set; }
    }
}
