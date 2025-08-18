using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsItem
    {
        public TwsItem()
        {
            TjobOrderD = new HashSet<TjobOrderD>();
            TjobOrderMaintainD = new HashSet<TjobOrderMaintainD>();
            TwsItemAlt = new HashSet<TwsItemAlt>();
            TwsPrOrderD = new HashSet<TwsPrOrderD>();
            TwsPurchaseD = new HashSet<TwsPurchaseD>();
            TwsSalesD = new HashSet<TwsSalesD>();
            TwsSalesReturnD = new HashSet<TwsSalesReturnD>();
            TwsStockOrderD = new HashSet<TwsStockOrderD>();
        }

        public string ItemId { get; set; }
        public string PartNo { get; set; }
        public string Description { get; set; }
        public string Specifications { get; set; }
        public string Location { get; set; }
        public string Made { get; set; }
        public string CatId { get; set; }
        public string Unit { get; set; }
        public double? Balance { get; set; }
        public string AssetTag { get; set; }

        public virtual ICollection<TjobOrderD> TjobOrderD { get; set; }
        public virtual ICollection<TjobOrderMaintainD> TjobOrderMaintainD { get; set; }
        public virtual ICollection<TwsItemAlt> TwsItemAlt { get; set; }
        public virtual ICollection<TwsPrOrderD> TwsPrOrderD { get; set; }
        public virtual ICollection<TwsPurchaseD> TwsPurchaseD { get; set; }
        public virtual ICollection<TwsSalesD> TwsSalesD { get; set; }
        public virtual ICollection<TwsSalesReturnD> TwsSalesReturnD { get; set; }
        public virtual ICollection<TwsStockOrderD> TwsStockOrderD { get; set; }
    }
}
