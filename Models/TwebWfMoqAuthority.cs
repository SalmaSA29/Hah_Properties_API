using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebWfMoqAuthority
    {
        public int AuthId { get; set; }
        public int? QmId { get; set; }
        public string UserHrCode { get; set; }
        public string PageName { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
