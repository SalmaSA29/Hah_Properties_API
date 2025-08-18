using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsComplainsD
    {
        public string DocNo { get; set; }
        public int RecordId { get; set; }
        public string Complains { get; set; }

        public virtual TjobOrderM DocNoNavigation { get; set; }
    }
}
