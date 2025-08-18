using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsSalesReturnM
    {
        public TwsSalesReturnM()
        {
            TwsSalesReturnD = new HashSet<TwsSalesReturnD>();
        }

        public string StockId { get; set; }
        public string DocNo { get; set; }
        public string FiscalYear { get; set; }
        public DateTime? Date { get; set; }
        public string CustId { get; set; }
        public string JobOrderId { get; set; }
        public string LastDocNo { get; set; }
        public string Descrp { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual ICollection<TwsSalesReturnD> TwsSalesReturnD { get; set; }
    }
}
