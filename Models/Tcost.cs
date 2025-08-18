using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Tcost
    {
        public Tcost()
        {
            TpettyD = new HashSet<TpettyD>();
        }

        public string CostId { get; set; }
        public string CostName { get; set; }
        public string CostNameE { get; set; }
        public string TaskId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<TpettyD> TpettyD { get; set; }
    }
}
