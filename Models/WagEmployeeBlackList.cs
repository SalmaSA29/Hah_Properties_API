using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagEmployeeBlackList
    {
        public string NationalId { get; set; }
        public string FullName { get; set; }
        public string Comments { get; set; }
    }
}
