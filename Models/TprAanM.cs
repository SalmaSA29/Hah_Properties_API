using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprAanM
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public string DocNo { get; set; }
        public DateTime? Date { get; set; }
        public string Descrp { get; set; }
        public double? CurrentBudget { get; set; }
        public DateTime? RequiredOnSiteDate { get; set; }
        public string Technically { get; set; }
        public string Price { get; set; }
        public string Delivery { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
