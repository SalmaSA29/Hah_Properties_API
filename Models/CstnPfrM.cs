using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnPfrM
    {
        public CstnPfrM()
        {
            CstnPfrD = new HashSet<CstnPfrD>();
        }

        public string ProjectId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string PfrNo { get; set; }
        public decimal? Total { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<CstnPfrD> CstnPfrD { get; set; }
    }
}
