using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrFingerPrintPayroll
    {
        public int PrId { get; set; }
        public DateTime? PrDay { get; set; }
        public string PrHrCode { get; set; }
        public string PrNotes { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string EffectShortcut { get; set; }
        public int? MonthPeriod { get; set; }
        public bool? IsClosed { get; set; }
    }
}
