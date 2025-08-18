using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrWorkExperience
    {
        public int SeekerId { get; set; }
        public int RecordId { get; set; }
        public string CompanyName { get; set; }
        public int? JobTitleId { get; set; }
        public int? IndustryId { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string PositionInCompany { get; set; }
        public string WorkDescription { get; set; }
    }
}
