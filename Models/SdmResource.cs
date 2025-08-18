using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SdmResource
    {
        public int UniqueId { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public byte[] Image { get; set; }
    }
}
