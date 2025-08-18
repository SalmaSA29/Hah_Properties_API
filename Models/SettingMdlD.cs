using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SettingMdlD
    {
        public string MdlName { get; set; }
        public string SubMdlName { get; set; }
        public bool Rul { get; set; }
        public int? Ordenal { get; set; }

        public virtual SettingMdl MdlNameNavigation { get; set; }
    }
}
