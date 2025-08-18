using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTtrade
    {
        public string TradeId { get; set; }
        public string TradeNme { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
