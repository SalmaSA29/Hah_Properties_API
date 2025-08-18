using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstFalseAccountM
    {
        public CstFalseAccountM()
        {
            CstFalseAccountD = new HashSet<CstFalseAccountD>();
        }

        public string ProjectId { get; set; }
        public string SupplierId { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CstFalseAccountD> CstFalseAccountD { get; set; }
    }
}
