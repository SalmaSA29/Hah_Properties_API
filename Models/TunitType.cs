using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TunitType
    {
        public string UnitType { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
