using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SapJobTitle
    {
        public int SapId { get; set; }
        public string SapName { get; set; }
        public int? SapGroup { get; set; }
    }
}
