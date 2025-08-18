using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecWebProfHist
    {
        public int? SeekerId { get; set; }
        public int ProfId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string JobTitle { get; set; }
        public string JobDesc { get; set; }
        public string Address { get; set; }
        public string Benefits { get; set; }
        public string CrossSalary { get; set; }
        public string ReasonOfLeaving { get; set; }

        public virtual HrSeekerWeb Seeker { get; set; }
    }
}
