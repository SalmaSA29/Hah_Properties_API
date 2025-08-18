using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingContactPersons
    {
        public int ContactId { get; set; }
        public double? SapCode { get; set; }
        public string ContactPerso { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
