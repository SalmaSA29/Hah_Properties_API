using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsPrOrderD
    {
        public string DocNo { get; set; }
        public string ItemId { get; set; }
        public double Qty { get; set; }
        public double? LastPrice { get; set; }
        public DateTime? LastDateIssue { get; set; }
        public string LastJobOrder { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual TwsPrOrderM DocNoNavigation { get; set; }
        public virtual TwsItem Item { get; set; }
    }
}
