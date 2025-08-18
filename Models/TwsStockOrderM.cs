using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsStockOrderM
    {
        public TwsStockOrderM()
        {
            TwsStockOrderD = new HashSet<TwsStockOrderD>();
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

        public virtual ICollection<TwsStockOrderD> TwsStockOrderD { get; set; }
    }
}
