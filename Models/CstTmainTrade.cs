using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTmainTrade
    {
        public string MainTradeId { get; set; }
        public string MainTradeNme { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
