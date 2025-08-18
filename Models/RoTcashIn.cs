using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoTcashIn
    {
        public int DocNo { get; set; }
        public string CashId { get; set; }
        public string RepresentativeId { get; set; }
        public string ClientId { get; set; }
        public double Total { get; set; }
        public string Descrp { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? Date { get; set; }
    }
}
