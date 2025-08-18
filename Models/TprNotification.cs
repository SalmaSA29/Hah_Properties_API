using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprNotification
    {
        public int Serial { get; set; }
        public int Type { get; set; }
        public string Notification { get; set; }
        public bool? Read { get; set; }
        public DateTime? Date { get; set; }
        public string UserId { get; set; }
        public string FromUserId { get; set; }
        public int? TaskId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public bool? Notified { get; set; }
        public int? DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
    }
}
