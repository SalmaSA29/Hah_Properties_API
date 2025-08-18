using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SP_UserApps
    {
        public int ID { get; set; }
        public string Sys_Name { get; set; }
        public string Sys_Icon { get; set; }
        public string Sys_Link { get; set; }
    }
}
