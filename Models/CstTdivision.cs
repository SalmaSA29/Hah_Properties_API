using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTdivision
    {
        public string DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
