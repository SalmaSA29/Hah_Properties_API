using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnTresourceGroupLevel3
    {
        public string ResourceGroupL3Id { get; set; }
        public string V { get; set; }
        public string ResourceGroupL3Name { get; set; }
        public string WorkPackageId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
