using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoTrepresentative
    {
        public RoTrepresentative()
        {
            RoSalesM = new HashSet<RoSalesM>();
            RoStocOutM = new HashSet<RoStocOutM>();
        }

        public string RepresentativeId { get; set; }
        public string RepresentativeName { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public virtual ICollection<RoSalesM> RoSalesM { get; set; }
        public virtual ICollection<RoStocOutM> RoStocOutM { get; set; }
    }
}
