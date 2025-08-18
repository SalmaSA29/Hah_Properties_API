using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecExitResault
    {
        public int Id { get; set; }
        public string UserHrCode { get; set; }
        public int ExtQusId { get; set; }
        public string RecruiterHrcode { get; set; }
        public int? InterviewId { get; set; }
        public bool? Rsault { get; set; }
        public string Comment { get; set; }
        public DateTime? InDate { get; set; }
    }
}
