using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoTunitType
    {
        public RoTunitType()
        {
            RoSalesD = new HashSet<RoSalesD>();
            RoStockOutD = new HashSet<RoStockOutD>();
            RoTitem = new HashSet<RoTitem>();
            RoTpurchaseD = new HashSet<RoTpurchaseD>();
        }

        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int? UnitCount { get; set; }

        public virtual ICollection<RoSalesD> RoSalesD { get; set; }
        public virtual ICollection<RoStockOutD> RoStockOutD { get; set; }
        public virtual ICollection<RoTitem> RoTitem { get; set; }
        public virtual ICollection<RoTpurchaseD> RoTpurchaseD { get; set; }
    }
}
