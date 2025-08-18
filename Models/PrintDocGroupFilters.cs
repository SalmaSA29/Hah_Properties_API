using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PrintDocGroupFilters
    {
        public string FormId { get; set; }
        public string FilterField { get; set; }
        public string FilterNameAr { get; set; }
        public string FilterNameEn { get; set; }

        public virtual CForm Form { get; set; }
    }
}
