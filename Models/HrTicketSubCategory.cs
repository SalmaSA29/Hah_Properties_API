using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrTicketSubCategory
    {
        public int SubId { get; set; }
        public int? CategoryId { get; set; }
        public string SubName { get; set; }
        public string SubUserHrcode { get; set; }
    }
}
