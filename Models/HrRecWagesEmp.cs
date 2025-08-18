using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecWagesEmp
    {
        public int WempId { get; set; }
        public string FullName { get; set; }
        public int? ProjectId { get; set; }
        public string NationalId { get; set; }
        public int? TitleId { get; set; }
        public string SuperVisionName { get; set; }
        public int? DailyRate { get; set; }
        public int? Status { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
