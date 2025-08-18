using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnInvoiceManPowerM
    {
        public CstnInvoiceManPowerM()
        {
            CstnInvoiceManPowerD = new HashSet<CstnInvoiceManPowerD>();
        }

        public string ProjectId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public decimal? Total { get; set; }

        public virtual ICollection<CstnInvoiceManPowerD> CstnInvoiceManPowerD { get; set; }
    }
}
