using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTopSheetCatBTrans
    {
        public int TopSheetCatBId { get; set; }
        public string ProjectId { get; set; }
        public double? Amount { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstTopSheetM Project { get; set; }
    }
}
