using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebInternalTrainers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? InternalServiceId { get; set; }
        public int? EmployeeId { get; set; }
        public string DepartmentId { get; set; }
        public string Project { get; set; }
        public DateTime? HiringDate { get; set; }
        public string Mobile { get; set; }
        public string Major { get; set; }
        public string University { get; set; }
        public int? GraduationYear { get; set; }
        public string PostGraduate { get; set; }
        public int? PostYear { get; set; }
        public string PostUniversity { get; set; }
        public string PostGrade { get; set; }
        public string Programs { get; set; }
        public string Reasons { get; set; }
        public string NationalId { get; set; }
        public string Faculty { get; set; }
        public string AccumulativeGrade { get; set; }
        public string MilitaryStatus { get; set; }
        public string CvName { get; set; }
    }
}
