using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsItemAlt
    {
        public string ItemId { get; set; }
        public string AltItemId { get; set; }
        public string Comments { get; set; }
        public double? Price { get; set; }
        public double? Ava { get; set; }
        public double? Orderd { get; set; }

        public virtual TwsItem Item { get; set; }
    }
}
