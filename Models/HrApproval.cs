using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrApproval
    {
        public int ApprovalId { get; set; }
        public int? InterviewId { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Organization1 { get; set; }
        public string Organization2 { get; set; }
        public string ProposedSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public bool? Car { get; set; }
        public string CarTxt { get; set; }
        public bool? Accommodation { get; set; }
        public string AccommodationTxt { get; set; }
        public bool? Mobile { get; set; }
        public string MobileTxt { get; set; }
        public string Grade { get; set; }
        public string ProjectAllowance { get; set; }
        public string MedicalInsurance { get; set; }
        public bool? ApprovalStep { get; set; }
        public bool? ApprovalStep2 { get; set; }
        public string ApprovalStepUser { get; set; }
        public DateTime? ApprovalStepUserDate { get; set; }
        public bool? Confirm1 { get; set; }
        public string Confirm1User { get; set; }
        public DateTime? Confirm1UserDate { get; set; }
        public bool? Confirm2 { get; set; }
        public string Confirm2User { get; set; }
        public DateTime? Confirm2UserDate { get; set; }
        public string HiringStatus { get; set; }
        public string ActionType { get; set; }
    }
}
