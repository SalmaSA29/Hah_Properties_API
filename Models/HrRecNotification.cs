using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecNotification
    {
        public int NoticId { get; set; }
        public string UserHrCode { get; set; }
        public string NoticTitle { get; set; }
        public string NoticDesc { get; set; }
        public DateTime? InDate { get; set; }
        public bool? Active { get; set; }
    }
}
