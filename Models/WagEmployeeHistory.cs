using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagEmployeeHistory
    {
        public int RecordNo { get; set; }
        public string EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Mobile1 { get; set; }
        public string JobTitleId { get; set; }
        public string GradeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public string GroupId { get; set; }
        public double? DailyRate { get; set; }
        public string SalaryTypeId { get; set; }
        public double? WorkingHours { get; set; }
        public string ProjectId { get; set; }
        public string IdCardNo { get; set; }
        public string Comments { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
