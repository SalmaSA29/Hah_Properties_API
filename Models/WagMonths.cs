using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagMonths
    {
        public int Id { get; set; }
        public int? MonthNo { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
