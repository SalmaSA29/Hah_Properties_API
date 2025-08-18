using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnVendorFalseAccountD
    {
        public string ProjectId { get; set; }
        public string SupplierId { get; set; }
        public int RecordId { get; set; }
        public string Description { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstnVendorFalseAccountM CstnVendorFalseAccountM { get; set; }
    }
}
