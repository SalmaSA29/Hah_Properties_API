using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Tconsultant
    {
        public string ConsultantId { get; set; }
        public string ConsultantName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public double? High { get; set; }
        public double? MedHigh { get; set; }
        public double? Med { get; set; }
        public double? MedLow { get; set; }
        public double? Low { get; set; }
        public double? Rank { get; set; }
        public string DbId { get; set; }
    }
}
