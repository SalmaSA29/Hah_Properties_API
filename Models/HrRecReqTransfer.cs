using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecReqTransfer
    {
        public int TransId { get; set; }
        public string TransRequester { get; set; }
        public int? TransInterviewId { get; set; }
        public string TransHrcode { get; set; }
        public int? TransFromProject { get; set; }
        public int? TransToProject { get; set; }
        public DateTime? TransLeavDate { get; set; }
        public DateTime? TransActionDate { get; set; }
        public string TransReason { get; set; }
        public DateTime? InDate { get; set; }
        public string ConfHr { get; set; }
        public DateTime? ConfHrDate { get; set; }
        public string ConfOldpm { get; set; }
        public string ConfOldoperation { get; set; }
        public string ConfPm { get; set; }
        public string ConfOperation { get; set; }
        public int? Status { get; set; }
    }
}
