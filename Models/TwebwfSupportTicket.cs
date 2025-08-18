using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfSupportTicket
    {
        public int RequestNo { get; set; }
        public DateTime? Date { get; set; }
        public string Email { get; set; }
        public int? Status { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string ApplicationId { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string AgreementNo { get; set; }
        public string ScNo { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string PriorityId { get; set; }
        public string SupportMessage { get; set; }
        public string AssignUserId { get; set; }
    }
}
