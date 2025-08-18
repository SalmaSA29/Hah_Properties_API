using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstClientInvoiceSubmittedM
    {
        public CstClientInvoiceSubmittedM()
        {
            CstClientInvoiceSubmittedD = new HashSet<CstClientInvoiceSubmittedD>();
        }

        public string ProjectId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime? Date { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CstClientInvoiceSubmittedD> CstClientInvoiceSubmittedD { get; set; }
    }
}
