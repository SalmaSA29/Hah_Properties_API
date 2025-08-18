using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItincludePr
    {
        public TwebwfItincludePr()
        {
            TwebwfItincludePrD = new HashSet<TwebwfItincludePrD>();
        }

        public int IncludeId { get; set; }
        public string ServiceId { get; set; }
        public int RequestNo { get; set; }
        public string InUserCode { get; set; }
        public DateTime? InDate { get; set; }
        public bool? Status { get; set; }
        public string OrderParty { get; set; }
        public string NecessaryFor { get; set; }
        public byte? PrId { get; set; }
        public int? DocNo { get; set; }

        public virtual ICollection<TwebwfItincludePrD> TwebwfItincludePrD { get; set; }
    }
}
