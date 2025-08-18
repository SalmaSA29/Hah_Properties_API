using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTresourceGroup
    {
        public string ResourceGroupId { get; set; }
        public string ResourceGroupName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
