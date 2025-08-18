using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanQsD
    {
        public int Serial { get; set; }
        public int? QsId { get; set; }
        public string Segmant { get; set; }
        public string Head1 { get; set; }
        public string Head2 { get; set; }
        public string Horiz1 { get; set; }
        public string Horiz2 { get; set; }
        public double? Number { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Z { get; set; }
        public double? Addition { get; set; }
        public double? Deduction { get; set; }
        public double? Total { get; set; }
        public string Notes { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
