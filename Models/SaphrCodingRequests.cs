using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SaphrCodingRequests
    {
        public SaphrCodingRequests()
        {
            SaphrCodingRequestsD = new HashSet<SaphrCodingRequestsD>();
        }

        public int ReqId { get; set; }
        public string UserHrCode { get; set; }
        public DateTime? InDate { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<SaphrCodingRequestsD> SaphrCodingRequestsD { get; set; }
    }
}
