using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagSubTrade
    {
        public string MainTradeId { get; set; }
        public string SubTradeId { get; set; }
        public string SubTradeName { get; set; }
    }
}
