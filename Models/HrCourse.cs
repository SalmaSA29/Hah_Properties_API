using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrCourse
    {
        public string SeekerId { get; set; }
        public int RecordId { get; set; }
        public string CourseOrCertificate { get; set; }
        public string CenterOrIssuer { get; set; }
        public string YearIssued { get; set; }
    }
}
