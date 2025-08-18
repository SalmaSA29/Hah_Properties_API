using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstStoreDataM
    {
        public CstStoreDataM()
        {
            CstStoreDataD = new HashSet<CstStoreDataD>();
        }

        public string ProjectId { get; set; }
        public DateTime? Date { get; set; }

        public virtual ICollection<CstStoreDataD> CstStoreDataD { get; set; }
    }
}
