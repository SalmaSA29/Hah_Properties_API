using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrackingPurchasingM
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
    }
}
