using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstOverAllDataM
    {
        public CstOverAllDataM()
        {
            CstOverAllDataD = new HashSet<CstOverAllDataD>();
        }

        public string ProjectId { get; set; }
        public DateTime? Date { get; set; }

        public virtual ICollection<CstOverAllDataD> CstOverAllDataD { get; set; }
    }
}
