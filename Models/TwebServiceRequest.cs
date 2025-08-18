using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebServiceRequest
    {
        public int ReqNo { get; set; }
        public string RequesterName { get; set; }
        public string EmployNo { get; set; }
        public string EmpTitleId { get; set; }
        public string EmpGrade { get; set; }
        public string EmpDepartmentId { get; set; }
        public string BuOrganizationId { get; set; }
        public string SiteOrLocation { get; set; }
        public string Comments { get; set; }
        public string EmpName { get; set; }
        public int? InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
