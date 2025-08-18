using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TndrTarea
    {
        public int AreaId { get; set; }
        public string ProjectId { get; set; }
        public string AreaName { get; set; }
        public double? Area { get; set; }
    }
}
