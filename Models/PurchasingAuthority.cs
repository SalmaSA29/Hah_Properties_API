using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PurchasingAuthority
    {
        public int AuthId { get; set; }
        public string AuthType { get; set; }
        public string AuthTypeCode { get; set; }
        public string AllowDepartment { get; set; }
        public string AllowEmpEmail { get; set; }
        public string Comment { get; set; }
    }
}
