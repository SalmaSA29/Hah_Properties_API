using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstIrLogM
    {
        public CstIrLogM()
        {
            CstIrLog = new HashSet<CstIrLog>();
        }

        public int Sn { get; set; }
        public string ProjectId { get; set; }
        public string Comments { get; set; }
        public DateTime? Date { get; set; }

        public virtual ICollection<CstIrLog> CstIrLog { get; set; }
    }
}
