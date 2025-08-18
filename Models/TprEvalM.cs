using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprEvalM
    {
        public TprEvalM()
        {
            TprEvalByProcD1 = new HashSet<TprEvalByProcD1>();
            TprEvalD = new HashSet<TprEvalD>();
        }

        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public double? OrginalValue { get; set; }
        public double? FinalValue { get; set; }
        public DateTime? Date { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public string Descrp { get; set; }

        public virtual ICollection<TprEvalByProcD1> TprEvalByProcD1 { get; set; }
        public virtual ICollection<TprEvalD> TprEvalD { get; set; }
    }
}
