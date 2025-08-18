using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagAttendance
    {
        public int ID { get; set; }
        public int? project_id { get; set; }
        public string MobileMacAddress { get; set; }
        public string UserHRCode { get; set; }
        public string LaborID { get; set; }
        public int? Action { get; set; }
        public bool? FollowStatus { get; set; }
        public int? AttendType { get; set; } //1=Face / 2-Scan / 3=Search / 4=Web / 5=FingerPrint 
        public DateTime? AttendTime { get; set; }
        public DateTime? InDate { get; set; }
    }
}
