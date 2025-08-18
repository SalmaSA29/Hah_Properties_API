using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfPermission
    {
        public int RequestNo { get; set; }
        public string ServiceId { get; set; }
        public string RequestHrCode { get; set; }
        public string OwnerHrCode { get; set; }
        public DateTime? Date { get; set; }
        public bool? NewComer { get; set; }
        public int? ApprovalPathId { get; set; }
        public int? Status { get; set; }
        public string Comments { get; set; }
        public string NplusEmail { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int Type { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string DateFromAmpm { get; set; }
        public string DateToAmpm { get; set; }
        public DateTime? PermissionDate { get; set; }
        public string ProjectId { get; set; }
    }
}
