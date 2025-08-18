using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TestHatEmp
    {
        public int RecrodNo { get; set; }
        public string Gps { get; set; }
        public string Empname { get; set; }
        public string Jobcode { get; set; }
        public string Grade { get; set; }
        public double? Dailyrate { get; set; }
        public string Idcard { get; set; }
        public DateTime? Startdate { get; set; }
        public string Project { get; set; }
        public DateTime? Birthdate { get; set; }
        public DateTime? Exitdate { get; set; }
    }
}
