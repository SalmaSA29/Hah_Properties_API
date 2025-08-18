using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RoTpurchaseM
    {
        public RoTpurchaseM()
        {
            RoTpurchaseD = new HashSet<RoTpurchaseD>();
        }

        public int DocNo { get; set; }
        public int StockId { get; set; }
        public string SuuplierId { get; set; }
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

        public virtual RoTsupplier Suuplier { get; set; }
        public virtual ICollection<RoTpurchaseD> RoTpurchaseD { get; set; }
    }
}
