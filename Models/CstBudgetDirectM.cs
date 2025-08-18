using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstBudgetDirectM
    {
        public CstBudgetDirectM()
        {
            CstBudgetDirect = new HashSet<CstBudgetDirect>();
        }

        public string ProjectId { get; set; }
        public bool? Submit { get; set; }
        public bool? Revised { get; set; }
        public bool? Approved { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CstBudgetDirect> CstBudgetDirect { get; set; }
    }
}
