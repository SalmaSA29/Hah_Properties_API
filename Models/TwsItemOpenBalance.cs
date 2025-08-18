using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsItemOpenBalance
    {
        public string ItemId { get; set; }
        public string StockId { get; set; }
        public double? Balance { get; set; }
    }
}
