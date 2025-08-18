using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecWebEducation
    {
        public int? SeekerId { get; set; }
        public int EduId { get; set; }
        public string University { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Degree { get; set; }
        public string FieldOfStudy { get; set; }

        public virtual HrSeekerWeb Seeker { get; set; }
    }
}
