using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoSalesM
    {
        public RoSalesM()
        {
            RoSalesD = new HashSet<RoSalesD>();
        }

        public int DocNo { get; set; }
        public int StockId { get; set; }
        public string ClientId { get; set; }
        public string RepresentativeId { get; set; }
        public DateTime? Date { get; set; }
        public double? Disc1 { get; set; }
        public double? Disc2 { get; set; }
        public double? Disc3 { get; set; }
        public double? Disc4 { get; set; }
        public double? Disc5 { get; set; }
        public double? Total { get; set; }
        public double? TotalDisc { get; set; }
        public double? Final { get; set; }
        public string Descrp { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public double? Paid { get; set; }
        public double? Remain { get; set; }

        public virtual RoTclient Client { get; set; }
        public virtual RoTrepresentative Representative { get; set; }
        public virtual ICollection<RoSalesD> RoSalesD { get; set; }
    }
}
