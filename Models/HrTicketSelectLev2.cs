using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrTicketSelectLev2
    {
        public HrTicketSelectLev2()
        {
            HrTicketSelectLev3 = new HashSet<HrTicketSelectLev3>();
        }

        public int Lev2Id { get; set; }
        public int? Lev1Id { get; set; }
        public string Lev2Name { get; set; }

        public virtual HrTicketSelectLev1 Lev1 { get; set; }
        public virtual ICollection<HrTicketSelectLev3> HrTicketSelectLev3 { get; set; }
    }
}
