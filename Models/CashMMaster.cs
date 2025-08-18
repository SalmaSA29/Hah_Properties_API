using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CashMMaster
    {
        public CashMMaster()
        {
            CashMOprDirBalance = new HashSet<CashMOprDirBalance>();
            CashMProjectsBalance = new HashSet<CashMProjectsBalance>();
        }

        public int CashId { get; set; }
        public double CashBalanceAmount { get; set; }
        public DateTime CashBalanceDateFrom { get; set; }
        public DateTime CashBalanceDateTo { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }

        public virtual ICollection<CashMOprDirBalance> CashMOprDirBalance { get; set; }
        public virtual ICollection<CashMProjectsBalance> CashMProjectsBalance { get; set; }
    }
}
