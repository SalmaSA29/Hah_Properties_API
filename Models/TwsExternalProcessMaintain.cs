using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsExternalProcessMaintain
    {
        public string DocNo { get; set; }
        public int RecordId { get; set; }
        public string ExternalProcess { get; set; }
        public double ExternalCost { get; set; }

        public virtual TjobOrderMaintainM DocNoNavigation { get; set; }
    }
}
