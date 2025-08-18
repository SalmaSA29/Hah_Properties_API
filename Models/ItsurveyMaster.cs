using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItsurveyMaster
    {
        public ItsurveyMaster()
        {
            ItsurveyDetails = new HashSet<ItsurveyDetails>();
        }

        public int EmpId { get; set; }
        public int? SurveyId { get; set; }
        public string UserHrcode { get; set; }
        public int? ProjectId { get; set; }
        public int? TitleId { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public string NationalId { get; set; }
        public DateTime? InDate { get; set; }
        public bool? Closed { get; set; }

        public virtual ICollection<ItsurveyDetails> ItsurveyDetails { get; set; }
    }
}
