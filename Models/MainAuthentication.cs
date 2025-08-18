using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MainAuthentication
    {
        public int AuthId { get; set; }
        public int? GroupId { get; set; }
        public int? SysId { get; set; }
        public DateTime AuthInDate { get; set; }
        public int AuthInUser { get; set; }
        public DateTime? AuthUpDate { get; set; }
        public int? AuthUpUser { get; set; }
    }
}
