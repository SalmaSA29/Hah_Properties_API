using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstBudgetVoM
    {
        public CstBudgetVoM()
        {
            CstBudgetVoDirectD = new HashSet<CstBudgetVoDirectD>();
            CstBudgetVoInDirectD = new HashSet<CstBudgetVoInDirectD>();
            CstBudgetVoTopSheetAD = new HashSet<CstBudgetVoTopSheetAD>();
            CstBudgetVoTopSheetBD = new HashSet<CstBudgetVoTopSheetBD>();
            CstBudgetVoTopSheetCD = new HashSet<CstBudgetVoTopSheetCD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public DateTime Date { get; set; }
        public bool? Submit { get; set; }
        public bool? Revised { get; set; }
        public bool? Approved { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CstBudgetVoDirectD> CstBudgetVoDirectD { get; set; }
        public virtual ICollection<CstBudgetVoInDirectD> CstBudgetVoInDirectD { get; set; }
        public virtual ICollection<CstBudgetVoTopSheetAD> CstBudgetVoTopSheetAD { get; set; }
        public virtual ICollection<CstBudgetVoTopSheetBD> CstBudgetVoTopSheetBD { get; set; }
        public virtual ICollection<CstBudgetVoTopSheetCD> CstBudgetVoTopSheetCD { get; set; }
    }
}
