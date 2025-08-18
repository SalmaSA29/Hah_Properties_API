using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagAreaBuilding
    {
        public string ProjectId { get; set; }
        public string BuildingCode { get; set; }
        public string BuildingName { get; set; }
        public int? Serial { get; set; }
    }
}
