using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstBudgetVoTopSheetBD
    {
        public int DocNo { get; set; }
        public int TopSheetCatBId { get; set; }
        public string ProjectId { get; set; }
        public double? Amount { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstBudgetVoM CstBudgetVoM { get; set; }
    }
}
