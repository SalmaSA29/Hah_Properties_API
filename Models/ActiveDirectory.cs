using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ActiveDirectory
    {
        public string Acemail { get; set; }
        public string Acpassword { get; set; }
        public DateTime? AclastEdit { get; set; }
        public bool? IsClosed { get; set; }
    }
}
