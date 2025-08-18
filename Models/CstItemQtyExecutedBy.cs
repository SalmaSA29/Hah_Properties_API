using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstItemQtyExecutedBy
    {
        public string ProjectId { get; set; }
        public string ItemNo { get; set; }
        public int AreaNo { get; set; }
        public string TaskId { get; set; }
        public double? Qty { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstTarea AreaNoNavigation { get; set; }
    }
}
