using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrCompetenciesAssessmentD
    {
        public string HrCompetenciesId { get; set; }
        public int HrAssessmentId { get; set; }
        public bool? Poor { get; set; }
        public bool? Marginal { get; set; }
        public bool? Acceptable { get; set; }
        public bool? Good { get; set; }
        public bool? Outstanding { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
