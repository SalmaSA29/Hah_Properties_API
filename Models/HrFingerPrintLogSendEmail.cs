using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrFingerPrintLogSendEmail
    {
        public int Id { get; set; }
        public DateTime? AttDate { get; set; }
        public string AttTime { get; set; }
        public int? EmailsCount { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
