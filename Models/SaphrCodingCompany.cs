using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SaphrCodingCompany
    {
        public int CompanyId { get; set; }
        public int? ParentDepId { get; set; }
        public string CompanyName { get; set; }
        public string UserHrCode { get; set; }
        public string UserHrCode1 { get; set; }
        public string UserHrCode2 { get; set; }
        public string UserHrCode3 { get; set; }
    }
}
