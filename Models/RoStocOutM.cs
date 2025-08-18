using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoStocOutM
    {
        public RoStocOutM()
        {
            RoStockOutD = new HashSet<RoStockOutD>();
        }

        public int DocNo { get; set; }
        public int StockId { get; set; }
        public string RepresentativeId { get; set; }
        public DateTime? Date { get; set; }
        public string Descrp { get; set; }

        public virtual RoTrepresentative Representative { get; set; }
        public virtual RoTstock Stock { get; set; }
        public virtual ICollection<RoStockOutD> RoStockOutD { get; set; }
    }
}
