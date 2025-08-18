using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MainGrades
    {
        public int ID { get; set; }
        public string Grade_Name { get; set; }
        public string In_User { get; set; }
        public DateTime In_Date { get; set; }
    }
}
