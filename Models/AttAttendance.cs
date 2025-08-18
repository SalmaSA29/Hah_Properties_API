using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class AttAttendance
    {
        public string UserHrCode { get; set; }
        public DateTime Date { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public double? LateTime { get; set; }
        public double? OverTime { get; set; }
    }
}
