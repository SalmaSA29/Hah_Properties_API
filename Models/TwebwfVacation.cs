using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfVacation
    {
        public int RequestNo { get; set; }
        public string ServiceId { get; set; }
        public string RequestHrCode { get; set; }
        public string OwnerHrCode { get; set; }
        public string Responsible { get; set; }
        public DateTime? Date { get; set; }
        public bool? NewComer { get; set; }
        public int? ApprovalPathId { get; set; }
        public int? Status { get; set; }
        public string Comments { get; set; }
        public string NplusEmail { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string VacationType { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? NoOfDays { get; set; }
        public DateTime? ReplacedWith { get; set; }
        public DateTime? ReplacedWithTo { get; set; }
        public string FileName { get; set; }
        public string ProjectId { get; set; }
    }
}
