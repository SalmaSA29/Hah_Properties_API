using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingM
    {
        public int MrId { get; set; }
        public string MrNo { get; set; }
        public string ProjectId { get; set; }
        public DateTime? MrDate { get; set; }
        public DateTime? MrReceivingDate { get; set; }
        public string MrAttachment { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
        public int? Status { get; set; }
        public string Comments { get; set; }
        public string TypeOfWork { get; set; }
        public DateTime? MgAprrovedDate { get; set; }
        public bool? Mstat { get; set; }
        public string Approval { get; set; }
        public string MrAttachment2 { get; set; }
        public string MrAttachment3 { get; set; }
        public string CancelReason { get; set; }
        public DateTime? Dateview { get; set; }
    }
}
