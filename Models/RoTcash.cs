using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoTcash
    {
        public RoTcash()
        {
            RoTcashOut = new HashSet<RoTcashOut>();
        }

        public string CashId { get; set; }
        public string CashName { get; set; }

        public virtual ICollection<RoTcashOut> RoTcashOut { get; set; }
    }
}
