using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class VacancyApply
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? HiringDate { get; set; }
        public string Mobile { get; set; }
        public int? MajorId { get; set; }
        public int? GraduationYear { get; set; }
        public int? ExperienceYear { get; set; }
        public string CvName { get; set; }
        public int? VacancyId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public int? InUser { get; set; }
        public DateTime? InDate { get; set; }
        public int? EmployeeCompany { get; set; }
    }
}
