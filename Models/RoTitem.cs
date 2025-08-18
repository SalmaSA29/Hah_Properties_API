using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoTitem
    {
        public RoTitem()
        {
            RoSalesD = new HashSet<RoSalesD>();
            RoStockOutD = new HashSet<RoStockOutD>();
            RoTpurchaseD = new HashSet<RoTpurchaseD>();
        }

        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public int? UnitId { get; set; }
        public string R { get; set; }

        public virtual RoTunitType Unit { get; set; }
        public virtual ICollection<RoSalesD> RoSalesD { get; set; }
        public virtual ICollection<RoStockOutD> RoStockOutD { get; set; }
        public virtual ICollection<RoTpurchaseD> RoTpurchaseD { get; set; }
    }
}
