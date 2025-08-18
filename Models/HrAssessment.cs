using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrAssessment
    {
        public int HrAssessmentId { get; set; }
        public int InterviewId { get; set; }
        public double? LastCurrentSalary { get; set; }
        public string CurrentCompany { get; set; }
        public string LastCurrentBenefits { get; set; }
        public bool? AbilityToTravelOutOfEgypt { get; set; }
        public double? ExpectedSalary { get; set; }
        public string ExpectedBenefits { get; set; }
        public string RecommendationNotes { get; set; }
        public int? Recommendation { get; set; }
        public string NoticePeriod { get; set; }
        public bool? OfferStep { get; set; }
        public bool? Confirm1 { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
