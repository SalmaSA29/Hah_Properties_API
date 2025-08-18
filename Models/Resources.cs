using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Resources
    {
        public int UniqueId { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public int? Color { get; set; }
        public byte[] Image { get; set; }
        public string CustomField1 { get; set; }
    }
}
