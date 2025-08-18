using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TbusinessType
    {
        public string BusinessTypeId { get; set; }
        public string BusinessTypeName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
