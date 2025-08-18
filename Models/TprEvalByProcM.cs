using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprEvalByProcM
    {
        public TprEvalByProcM()
        {
            TprEvalByProcD = new HashSet<TprEvalByProcD>();
        }

        public string UserId { get; set; }
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

        public virtual ICollection<TprEvalByProcD> TprEvalByProcD { get; set; }
    }
}
