using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfBusinessCard
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
        public string CardNo { get; set; }
        public string CostCenter { get; set; }
        public string CardName { get; set; }
        public string FaxNo { get; set; }
        public string ExtNo { get; set; }
        public string MobileNo { get; set; }
        public string ProjectId { get; set; }
    }
}
