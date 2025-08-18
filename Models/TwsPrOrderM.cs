using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsPrOrderM
    {
        public TwsPrOrderM()
        {
            TwsPrOrderD = new HashSet<TwsPrOrderD>();
            TwsPurchaseM = new HashSet<TwsPurchaseM>();
        }

        public string DocNo { get; set; }
        public DateTime? Date { get; set; }
        public string Descrp { get; set; }
        public string JobOrderId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public bool? Closed { get; set; }

        public virtual TjobOrderM JobOrder { get; set; }
        public virtual ICollection<TwsPrOrderD> TwsPrOrderD { get; set; }
        public virtual ICollection<TwsPurchaseM> TwsPurchaseM { get; set; }
    }
}
