using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SP_HRFingerPrintFinal
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public bool Holiday { get; set; }
        public int MonthPeriod { get; set; }
        public string Finger_HRCode { get; set; }
        public string Time_IN { get; set; }
        public string Time_OUT { get; set; }
        public int? Vacation { get; set; }
        public int? Permission { get; set; }
        public int? BusinessMission { get; set; }
        public int? Forget { get; set; }
        public string Deduction { get; set; }
    }
}
