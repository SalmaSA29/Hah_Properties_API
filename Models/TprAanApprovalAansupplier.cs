using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprAanApprovalAansupplier
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int DocNo { get; set; }
        public int SupplierId { get; set; }
        public bool? Selected { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual TprAanApproval TprAanApproval { get; set; }
    }
}
