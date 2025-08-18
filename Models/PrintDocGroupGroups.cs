using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PrintDocGroupGroups
    {
        public string FormId { get; set; }
        public string GroupField { get; set; }
        public string GroupNameAr { get; set; }
        public string GroupNameEn { get; set; }

        public virtual CForm Form { get; set; }
    }
}
