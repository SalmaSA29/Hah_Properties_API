using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TndrTbuilding
    {
        public int BuildingId { get; set; }
        public string ProjectId { get; set; }
        public string BuildingName { get; set; }
        public int? Count { get; set; }
    }
}
