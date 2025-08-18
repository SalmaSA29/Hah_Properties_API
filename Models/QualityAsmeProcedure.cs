using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class QualityAsmeProcedure
    {
        public int ProId { get; set; }
        public int? DepId { get; set; }
        public string ProName { get; set; }
        public string ProFile { get; set; }
        public string ProCode { get; set; }
        public DateTime? ProDate { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
