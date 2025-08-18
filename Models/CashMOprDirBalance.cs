using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CashMOprDirBalance
    {
        public int OprDirId { get; set; }
        public int CashId { get; set; }
        public string OprHrCode { get; set; }
        public double? OprDirTotInvoice { get; set; }
        public double? OprDirBalance { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }

        public virtual CashMMaster Cash { get; set; }
    }
}
