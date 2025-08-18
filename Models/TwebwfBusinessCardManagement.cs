using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfBusinessCardManagement
    {
        public int BusinessCardId { get; set; }
        public byte[] Image { get; set; }
        public string FullData { get; set; }
    }
}
