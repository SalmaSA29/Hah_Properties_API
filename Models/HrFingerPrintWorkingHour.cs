using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrFingerPrintWorkingHour
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public bool? Holiday { get; set; }
        public int? MonthPeriod { get; set; }
        public bool? Closed { get; set; }
    }
}
