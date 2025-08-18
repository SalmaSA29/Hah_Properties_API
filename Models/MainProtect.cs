using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MainProtect
    {
        public int ProtectId { get; set; }
        public int? UserId { get; set; }
        public string ProtectComputer { get; set; }
    }
}
