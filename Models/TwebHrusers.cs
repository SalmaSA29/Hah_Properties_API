using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebHrusers
    {
        public string UserHrCode { get; set; }
        public string UserFullName { get; set; }
        public string Email { get; set; }
        public string JobTitleId { get; set; }
        public bool? Admin { get; set; }
    }
}
