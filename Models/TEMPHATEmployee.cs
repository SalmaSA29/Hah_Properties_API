using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TEMPHATEmployee
    {
        public string EmployeeNo { get; set; }
        public string Name { get; set; }
        public string HRCode { get; set; }
        public int? IsEmp { get; set; }
        public DateTime? InDate { get; set; }
        public int? InUser { get; set; }
    }
}
