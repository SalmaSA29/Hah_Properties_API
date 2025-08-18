using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstClientInvoiceApprovedD
    {
        public string ProjectId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string ItemNo { get; set; }
        public decimal? Qty { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstClientInvoiceApprovedM CstClientInvoiceApprovedM { get; set; }
    }
}
