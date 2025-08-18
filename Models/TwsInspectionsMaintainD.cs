using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsInspectionsMaintainD
    {
        public string DocNo { get; set; }
        public string InspectionId { get; set; }
        public string Comments { get; set; }

        public virtual TjobOrderMaintainM DocNoNavigation { get; set; }
        public virtual TwsInspection Inspection { get; set; }
    }
}
