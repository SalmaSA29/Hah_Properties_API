using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PAY_Active_Month
    {
        public int ID { get; set; }
        public string Pay_Month { get; set; }
        public bool? Active { get; set; }
        public string DepartmentID { get; set; }
    }
}
