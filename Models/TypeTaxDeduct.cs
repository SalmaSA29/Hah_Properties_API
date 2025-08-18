using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TypeTaxDeduct
    {
        public byte TypeId { get; set; }
        public string TypeDeduct { get; set; }
        public string TypeDeductEn { get; set; }
        public double PercDeduct { get; set; }
        public double? Perc { get; set; }
    }
}
