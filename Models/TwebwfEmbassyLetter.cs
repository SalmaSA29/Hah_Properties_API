using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfEmbassyLetter
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
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Purpose { get; set; }
        public string EmbassyId { get; set; }
        public string PassportNo { get; set; }
        public string AddSalary { get; set; }
        public string SocialInsuranceNumber { get; set; }
        public string ProjectId { get; set; }
    }
}
