using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoTspent
    {
        public RoTspent()
        {
            RoTcashOut = new HashSet<RoTcashOut>();
        }

        public int SpentId { get; set; }
        public string SpentName { get; set; }

        public virtual ICollection<RoTcashOut> RoTcashOut { get; set; }
    }
}
