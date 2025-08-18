using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrLocation
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int? AreaId { get; set; }
        public bool? UpdatedRec { get; set; }
    }
}
