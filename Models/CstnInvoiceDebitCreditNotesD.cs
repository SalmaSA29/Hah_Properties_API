using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnInvoiceDebitCreditNotesD
    {
        public string ProjectId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string CostId { get; set; }
        public string CostIdTo { get; set; }
        public decimal Amount { get; set; }
        public string Comments { get; set; }

        public virtual CstnInvoiceDebitCreditNotesM CstnInvoiceDebitCreditNotesM { get; set; }
    }
}
