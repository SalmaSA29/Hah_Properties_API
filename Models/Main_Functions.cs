using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalAPI.Models
{
    public partial class Main_Functions
    {
        public int ID { get; set; }
        public string Department_ID { get; set; }
        public string Function_Name { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; }
    }
}
