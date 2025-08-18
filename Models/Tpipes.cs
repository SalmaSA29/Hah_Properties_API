using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Tpipes
    {
        public Tpipes()
        {
            TpipesD = new HashSet<TpipesD>();
        }

        public int DocNo { get; set; }
        public DateTime? Date { get; set; }
        public bool? ShowDetails { get; set; }
        public string ProjectId { get; set; }
        public string MainContractor { get; set; }
        public string Subcontractor { get; set; }

        public virtual ICollection<TpipesD> TpipesD { get; set; }
    }
}
