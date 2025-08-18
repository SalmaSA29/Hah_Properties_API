using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TenderD
    {
        public int DetId { get; set; }
        public int? TenderId { get; set; }
        public int? TenderTransaction { get; set; }
        public int? TransStatus { get; set; }
        public DateTime? TransDate { get; set; }
    }
}
