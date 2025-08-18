using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstAgreementBqoRelation
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string ItemNo { get; set; }
        public string BqoItem { get; set; }
        public string TaskId { get; set; }
        public double? Ratio { get; set; }
    }
}
