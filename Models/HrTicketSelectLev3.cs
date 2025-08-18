using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrTicketSelectLev3
    {
        public int Lev3Id { get; set; }
        public int? Lev2Id { get; set; }
        public string Lev3Name { get; set; }

        public virtual HrTicketSelectLev2 Lev2 { get; set; }
    }
}
