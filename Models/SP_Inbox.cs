using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SP_Inbox
    {
        public int ID { get; set; }
        public string All { get; set; }
        public DateTime CreateDate { get; set; }
        public string link { get; set; }
    }
}
