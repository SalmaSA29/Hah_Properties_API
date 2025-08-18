using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TEMPHATAttend
    {
        public int Id { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? TimeIn { get; set; }
        public double Temperature { get; set; }
        public DateTime? TemperatureTime { get; set; }
        public TimeSpan? TimeOut { get; set; }
        public int? In_User { get; set; }
    }
}
