using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TcostType
    {
        public string CostTypeId { get; set; }
        public string CostTypeName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
