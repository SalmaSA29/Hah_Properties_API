using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstMaterial
    {
        public string MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string Unit { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
