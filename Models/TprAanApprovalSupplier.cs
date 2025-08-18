using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprAanApprovalSupplier
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int DocNo { get; set; }
        public string SupplierId { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual TprAanApproval TprAanApproval { get; set; }
    }
}
