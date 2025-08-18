using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebSummerTraining
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Major { get; set; }
        public string University { get; set; }
        public int? GraduationYear { get; set; }
        public string CvName { get; set; }
        public string NationalId { get; set; }
        public string Address { get; set; }
        public string Governorate { get; set; }
        public DateTime? InDate { get; set; }
        public int? Currentacademicyear { get; set; }
    }
}
