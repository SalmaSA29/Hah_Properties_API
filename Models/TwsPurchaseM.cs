using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsPurchaseM
    {
        public TwsPurchaseM()
        {
            TwsPurchaseD = new HashSet<TwsPurchaseD>();
        }

        public string StockId { get; set; }
        public string DocNo { get; set; }
        public string FiscalYear { get; set; }
        public DateTime? Date { get; set; }
        public string SuppId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string JobOrderId { get; set; }
        public string PrOrderNo { get; set; }
        public string SupplyOrderNo { get; set; }
        public string Descrp { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual TjobOrderM JobOrder { get; set; }
        public virtual TwsPrOrderM PrOrderNoNavigation { get; set; }
        public virtual ICollection<TwsPurchaseD> TwsPurchaseD { get; set; }
    }
}
