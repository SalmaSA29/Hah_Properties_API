using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrTecAssessment
    {
        public int HrTechnicalId { get; set; }
        public int? InterviewId { get; set; }
        public string TecComment { get; set; }
        public int? Recommendation { get; set; }
        public string FileAttach { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
