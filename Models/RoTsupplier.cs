using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoTsupplier
    {
        public RoTsupplier()
        {
            RoTpurchaseM = new HashSet<RoTpurchaseM>();
        }

        public string SuuplierId { get; set; }
        public string SupplierName { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public virtual ICollection<RoTpurchaseM> RoTpurchaseM { get; set; }
    }
}
