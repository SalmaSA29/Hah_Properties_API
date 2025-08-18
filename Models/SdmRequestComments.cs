using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SdmRequestComments
    {
        public int Id { get; set; }
        public int? ReqId { get; set; }
        public string CommUser { get; set; }
        public string CommFile { get; set; }
        public string Comment { get; set; }
        public DateTime? InDate { get; set; }

        public virtual SdmRequest Req { get; set; }
    }
}
