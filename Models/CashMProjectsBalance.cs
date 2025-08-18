using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CashMProjectsBalance
    {
        public int CashProId { get; set; }
        public int CashId { get; set; }
        public int ProjectId { get; set; }
        public double? CashProTotInvoice { get; set; }
        public double? CashProBalance { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }

        public virtual CashMMaster Cash { get; set; }
    }
}
