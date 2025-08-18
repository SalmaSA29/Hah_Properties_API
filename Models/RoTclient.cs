using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoTclient
    {
        public RoTclient()
        {
            RoSalesM = new HashSet<RoSalesM>();
        }

        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public virtual ICollection<RoSalesM> RoSalesM { get; set; }
    }
}
