using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MainAuthority
    {
        public int AuthId { get; set; }
        public int? UserId { get; set; }
        public int? GroupId { get; set; }
        public int? PageId { get; set; }
        public bool? FunRead { get; set; }
        public bool? FunUpdate { get; set; }
        public bool? FunDelete { get; set; }
        public bool? FunNew { get; set; }
        public DateTime AuthInDate { get; set; }
        public int AuthInUser { get; set; }
        public DateTime? AuthUpDate { get; set; }
        public int? AuthUpUser { get; set; }
    }
}
