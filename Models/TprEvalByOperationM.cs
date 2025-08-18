using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprEvalByOperationM
    {
        public TprEvalByOperationM()
        {
            TprEvalByOperationD = new HashSet<TprEvalByOperationD>();
        }

        public string ProjectManagerId { get; set; }
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

        public virtual ICollection<TprEvalByOperationD> TprEvalByOperationD { get; set; }
    }
}
