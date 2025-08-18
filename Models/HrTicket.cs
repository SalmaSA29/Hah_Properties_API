using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrTicket
    {
        public int Id { get; set; }
        public int? Lev1Id { get; set; }
        public int? Lev2Id { get; set; }
        public int? Lev3Id { get; set; }
        public int? ProjectId { get; set; }
        public string Subject { get; set; }
        public int? Type { get; set; }
        public string Description { get; set; }
        public string UserHrCode { get; set; }
        public string OnBehave { get; set; }
        public DateTime? InDate { get; set; }
        public string Attached { get; set; }
        public string Status { get; set; }
        public bool? CreatorConfirm { get; set; }
    }
}
