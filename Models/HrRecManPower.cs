using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecManPower
    {
        public int ManId { get; set; }
        public string GroupId { get; set; }
        public int? InterviewId { get; set; }
        public DateTime? RequetDate { get; set; }
        public DateTime? NeedDate { get; set; }
        public string Name { get; set; }
        public int? JobListId { get; set; }
        public string Major { get; set; }
        public DateTime? StartDate { get; set; }
        public string Comments { get; set; }
        public string Extension { get; set; }
        public int? LocationId { get; set; }
    }
}
