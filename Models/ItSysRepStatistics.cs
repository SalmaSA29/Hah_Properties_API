using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItSysRepStatistics
    {
        public int Id { get; set; }
        public int? SysId { get; set; }
        public double? CountTrans { get; set; }
        public double? CountUsers { get; set; }
        public double? DailyTrans { get; set; }
        public double? TransPerUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
