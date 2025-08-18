using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SaphrCodingPosition
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public int? GroupPos { get; set; }
        public int? GroupPos1 { get; set; }
        public int? GroupPos2 { get; set; }
        public int? GroupPos3 { get; set; }
        public bool? ShowAll { get; set; }
    }
}
