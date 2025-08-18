using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrTicketSelectLev1
    {
        public HrTicketSelectLev1()
        {
            HrTicketSelectLev2 = new HashSet<HrTicketSelectLev2>();
        }

        public int Lev1Id { get; set; }
        public string Lev1Name { get; set; }

        public virtual ICollection<HrTicketSelectLev2> HrTicketSelectLev2 { get; set; }
    }
}
