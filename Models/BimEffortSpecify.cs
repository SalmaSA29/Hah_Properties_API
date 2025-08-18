using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class BimEffortSpecify
    {
        public int EffortSpecifyId { get; set; }
        public string EffortSpecifyName { get; set; }
        public int? EffortId { get; set; }
        public int? ProjectId { get; set; }
        public string InUser { get; set; }
        public DateTime? EffortSpecifyDate { get; set; }
        public int? PartId { get; set; }
        public int? FloorId { get; set; }
    }
}
