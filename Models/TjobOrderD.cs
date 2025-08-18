using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TjobOrderD
    {
        public string DocNo { get; set; }
        public int RecordId { get; set; }
        public string ItemId { get; set; }
        public double Qty { get; set; }
        public double? Ava { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }
        public DateTime? LastDateIssue { get; set; }
        public string LastJobOrder { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }

        public virtual TjobOrderM DocNoNavigation { get; set; }
        public virtual TwsItem Item { get; set; }
    }
}
