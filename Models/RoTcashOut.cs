using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoTcashOut
    {
        public int DocNo { get; set; }
        public string CashId { get; set; }
        public int SpentId { get; set; }
        public double Total { get; set; }
        public string Descrp { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? Date { get; set; }

        public virtual RoTcash Cash { get; set; }
        public virtual RoTspent Spent { get; set; }
    }
}
