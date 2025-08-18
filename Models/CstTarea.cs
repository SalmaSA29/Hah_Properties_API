using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTarea
    {
        public CstTarea()
        {
            CstItemQtyAssumed = new HashSet<CstItemQtyAssumed>();
            CstItemQtyExecutedBy = new HashSet<CstItemQtyExecutedBy>();
            CstItemQtySubmitted = new HashSet<CstItemQtySubmitted>();
            CstItemQtySubmittedSupplier = new HashSet<CstItemQtySubmittedSupplier>();
            CstItemQtyWorkDoneToDate = new HashSet<CstItemQtyWorkDoneToDate>();
        }

        public int AreaNo { get; set; }
        public string AreaName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string ProjectId { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<CstItemQtyAssumed> CstItemQtyAssumed { get; set; }
        public virtual ICollection<CstItemQtyExecutedBy> CstItemQtyExecutedBy { get; set; }
        public virtual ICollection<CstItemQtySubmitted> CstItemQtySubmitted { get; set; }
        public virtual ICollection<CstItemQtySubmittedSupplier> CstItemQtySubmittedSupplier { get; set; }
        public virtual ICollection<CstItemQtyWorkDoneToDate> CstItemQtyWorkDoneToDate { get; set; }
    }
}
