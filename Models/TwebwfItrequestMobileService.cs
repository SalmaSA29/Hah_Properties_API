using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItrequestMobileService
    {
        public int RequestNo { get; set; }
        public string ServiceId { get; set; }
        public string ProjectId { get; set; }
        public string RequestHrCode { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsPermanent { get; set; }
        public string Comments { get; set; }
        public int? Status { get; set; }
        public string RejectedHrCode { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? ReRequestCode { get; set; }
    }
}
