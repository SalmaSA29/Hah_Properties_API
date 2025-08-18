using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoTstock
    {
        public RoTstock()
        {
            RoStocOutM = new HashSet<RoStocOutM>();
        }

        public int StockId { get; set; }
        public string StockName { get; set; }

        public virtual ICollection<RoStocOutM> RoStocOutM { get; set; }
    }
}
