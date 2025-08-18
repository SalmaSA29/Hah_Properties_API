using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MappingSheet
    {
        public string VendorId { get; set; }
        public string SapId { get; set; }
        public string NameA { get; set; }
        public string NameE { get; set; }
        public int? HaHcoCode { get; set; }
    }
}
