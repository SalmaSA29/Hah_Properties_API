using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItrequestEquipment
    {
        public int RequestNo { get; set; }
        public string ServiceId { get; set; }
        public string DepartmentId { get; set; }
        public string ProjectId { get; set; }
        public string LocationId { get; set; }
        public string RequestHrCode { get; set; }
        public DateTime? Date { get; set; }
        public string Comments { get; set; }
        public bool? NewComer { get; set; }
        public int? ApprovalPathId { get; set; }
        public int? Status { get; set; }
        public string NplusEmail { get; set; }
        public string Equipment_File { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? ReRequestCode { get; set; }
        public int? MainDepartment { get; set; }
    }
}
