using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TenderM
    {
        public int TenderId { get; set; }
        public string InvitatiomNo { get; set; }
        public string InvitationString { get; set; }
        public string TenderNo { get; set; }
        public string TenderString { get; set; }
        public DateTime? TenderDate { get; set; }
        public string ProjectName { get; set; }
        public string Projshorttext { get; set; }
        public int? TenderPhase { get; set; }
        public int? TenderCategory { get; set; }
        public string Location { get; set; }
        public int? District { get; set; }
        public int? Country { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public string ResponsibleEngineer { get; set; }
        public int? Department { get; set; }
        public bool? Atd { get; set; }
        public bool? Btd { get; set; }
        public bool? Ctd { get; set; }
        public bool? Isd { get; set; }
        public bool? Mei { get; set; }
        public int? Status { get; set; }
        public string RowColor { get; set; }
        public string SubmissionColor { get; set; }
        public string Remarks { get; set; }
        public string RemarksUpdate { get; set; }
        public bool? Adjusted { get; set; }
        public string Lang { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
