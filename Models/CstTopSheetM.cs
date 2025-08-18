using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTopSheetM
    {
        public CstTopSheetM()
        {
            CstTopSheetCatATrans = new HashSet<CstTopSheetCatATrans>();
            CstTopSheetCatBTrans = new HashSet<CstTopSheetCatBTrans>();
            CstTopSheetCatCTrans = new HashSet<CstTopSheetCatCTrans>();
        }

        public string ProjectId { get; set; }
        public bool? Submit { get; set; }
        public bool? Revised { get; set; }
        public bool? Approved { get; set; }
        public double? OriginalContractValue { get; set; }
        public double? CurrentContractValue { get; set; }

        public virtual ICollection<CstTopSheetCatATrans> CstTopSheetCatATrans { get; set; }
        public virtual ICollection<CstTopSheetCatBTrans> CstTopSheetCatBTrans { get; set; }
        public virtual ICollection<CstTopSheetCatCTrans> CstTopSheetCatCTrans { get; set; }
    }
}
