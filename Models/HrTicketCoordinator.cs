using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrTicketCoordinator
    {
        public int CoorId { get; set; }
        public int? LocationId { get; set; }
        public string CoorUserHrCode { get; set; }
    }
}
