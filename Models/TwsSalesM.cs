using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsSalesM
    {
        public TwsSalesM()
        {
            TwsSalesD = new HashSet<TwsSalesD>();
        }

        public string StockId { get; set; }
        public string DocNo { get; set; }
        public string FiscalYear { get; set; }
        public DateTime? Date { get; set; }
        public string CustId { get; set; }
        public string JobOrderId { get; set; }
        public string StockRequestNo { get; set; }
        public string Descrp { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual TjobOrderM JobOrder { get; set; }
        public virtual ICollection<TwsSalesD> TwsSalesD { get; set; }
    }
}
