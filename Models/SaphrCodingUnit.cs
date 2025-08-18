using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SaphrCodingUnit
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int? GroupUnit { get; set; }
    }
}
