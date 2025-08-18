using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrFingerPrintAtt
    {
        public int Id { get; set; }
        public int? project_id { get; set; }
        public int? FingerId { get; set; }
        public string FingerIp { get; set; }
        public string FingerHrcode { get; set; }
        public int? FingerVerifyMode { get; set; }
        public int? FingerInOutMode { get; set; }
        public DateTime? FingerTime { get; set; }
        public int? FingerWorkcode { get; set; }
        public int? AttendType { get; set; } //1=Face / 2-Scan / 3=Search / 4=Web / 5 OR NULL = FingerPrint 
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
