using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTresourceGroupLevel2
    {
        public string ResourceGroupL2Id { get; set; }
        public string ResourceGroupL2Name { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
