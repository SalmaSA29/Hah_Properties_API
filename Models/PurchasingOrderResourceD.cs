using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PurchasingOrderResourceD
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int DocNo { get; set; }
        public string ItemNo { get; set; }
        public string ResourceId { get; set; }
        public string RequiredOnSiteDate { get; set; }
        public string _3monthsLookAhead { get; set; }
    }
}
