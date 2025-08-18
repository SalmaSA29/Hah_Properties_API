using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTopSheetCatATrans
    {
        public int TopSheetCatAId { get; set; }
        public string ProjectId { get; set; }
        public double? Amount { get; set; }
        public double? OriginalContractValue { get; set; }
        public double? CurrentContractValue { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CstTopSheetM Project { get; set; }
    }
}
