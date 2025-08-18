using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SdmRequest
    {
        public SdmRequest()
        {
            SdmRequestComments = new HashSet<SdmRequestComments>();
        }

        public int ReqId { get; set; }
        public int? ReqProject { get; set; }
        public string ReqUser { get; set; }
        public DateTime? ReqDate { get; set; }
        public string ReqComment { get; set; }
        public string ReqFile { get; set; }
        public int? ReqStatus { get; set; }

        public virtual ICollection<SdmRequestComments> SdmRequestComments { get; set; }
    }
}
