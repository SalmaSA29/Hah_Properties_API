using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstCompanyPerformanceM
    {
        public string ProjectId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int? FirstInvoiceYear { get; set; }
        public int? FirstInvoiceMonth { get; set; }
        public int? LastInvoiceYear { get; set; }
        public int? LastInvoiceMonth { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual CstCompanyPerformanceD CstCompanyPerformanceD { get; set; }
        public virtual CstCompanyPerformanceResD CstCompanyPerformanceResD { get; set; }
    }
}
