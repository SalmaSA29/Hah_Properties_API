using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTtransferM
    {
        public CstTtransferM()
        {
            CstTtransferAddingD = new HashSet<CstTtransferAddingD>();
            CstTtransferArea = new HashSet<CstTtransferArea>();
            CstTtransferD = new HashSet<CstTtransferD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string ItemNo { get; set; }
        public string TaskId { get; set; }
        public DateTime? Date { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CstTtransferAddingD> CstTtransferAddingD { get; set; }
        public virtual ICollection<CstTtransferArea> CstTtransferArea { get; set; }
        public virtual ICollection<CstTtransferD> CstTtransferD { get; set; }
    }
}
