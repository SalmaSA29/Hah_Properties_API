using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class BimLevel
    {
        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public int? FloorId { get; set; }
        public int? ProjectId { get; set; }
        public string InUser { get; set; }
        public DateTime? PartDate { get; set; }
    }
}
