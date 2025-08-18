using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnTresourceMaterialD
    {
        public string ResourceId { get; set; }
        public string MaterialId { get; set; }
        public int RecordId { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstnTresource Resource { get; set; }
    }
}
