using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class AppraisalEmp
    {
        public int ID { get; set; }
        public int AppID { get; set; }
        public string HrCode { get; set; }
        public int Status { get; set; }
        public double? CompanyScore { get; set; }
        public double? DepartmentScore { get; set; }
        public double? Competencescore { get; set; }
        public double? IndividualScore { get; set; }
        public double? Realindividualscore { get; set; }
        public double? Overallscore { get; set; }
        public string Trainingneeds { get; set; }
        public bool? Acknowledge1 { get; set; }
        public bool? Acknowledge2 { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
