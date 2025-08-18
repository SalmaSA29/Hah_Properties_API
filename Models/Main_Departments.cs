using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalAPI.Models
{
    public partial class Main_Departments
    {
        [Key]
        public int ID { get; set; }
        public string Department_Name { get; set; }
        public bool? IsSupportive { get; set; }
        public string In_User { get; set; }
        public DateTime? In_Date { get; set; }
    }
}
