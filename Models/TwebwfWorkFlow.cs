using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfWorkFlow
    {
        public int Serial { get; set; }
        public int? DetailApprovalId { get; set; }
        public int RequestNo { get; set; }
        public string ServiceId { get; set; }
        public string UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string SubmitedToUser { get; set; }
        public string Comments { get; set; }
        public bool? Read { get; set; }
        public int? Status { get; set; }
    }
}
