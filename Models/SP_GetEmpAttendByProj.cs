using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SP_GetEmpAttendByProj
    {
        public Int64 ID { get; set; }
        public string Employee_Code { get; set; }
        public string Employee_Name { get; set; }
        public string Title { get; set; }
        public DateTime AttendTime { get; set; }
        public int? AttendType { get; set; } //1=Face / 2-Scan / 3=Search / 4=Web
        public string UserHRCode { get; set; }
        public bool? IsLabor { get; set; }
    }
}