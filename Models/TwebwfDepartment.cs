using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalAPI.Models
{
    public partial class TwebwfDepartment
    {
        [Key]
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Department_Director { get; set; }
        public string Shortcut { get; set; }
        public string Isproject { get; set; }
        public int? Department_Index { get; set; }
    }
}
