using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrInterviewRequest
    {
        public int InterviewId { get; set; }
        public int? GroupId { get; set; }
        public int? SeekerId { get; set; }
        public DateTime? InterviewStartDate { get; set; }
        public DateTime? InterviewEndDate { get; set; }
        public string PreparedUserHrCode { get; set; }
        public string UserTechCode { get; set; }
        public string Comments { get; set; }
        public int? Status { get; set; }
        public string Major { get; set; }
        public string InterStep { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public bool? IsAccepted { get; set; }
        public string RejectedReasone { get; set; }
        public string PersonalCode { get; set; }
        public string FlagComment { get; set; }
    }
}
