using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstKpiList
    {
        public int KpiSerial { get; set; }
        public string Kpi { get; set; }
        public double? Weight { get; set; }
        public string Group { get; set; }
        public string GroupId { get; set; }
    }
}
