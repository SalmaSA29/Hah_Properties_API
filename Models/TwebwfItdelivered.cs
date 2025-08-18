using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItdelivered
    {
        public TwebwfItdelivered()
        {
            TwebwfItdeliveredD = new HashSet<TwebwfItdeliveredD>();
        }

        public int DeliveryNo { get; set; }
        public string DeliveryHrCode { get; set; }
        public DateTime? Date { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<TwebwfItdeliveredD> TwebwfItdeliveredD { get; set; }
    }
}
