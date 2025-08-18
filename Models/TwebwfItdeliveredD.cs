using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItdeliveredD
    {
        public int DeliveryDetId { get; set; }
        public int DeliveryNo { get; set; }
        public int DelServiceId { get; set; }
        public int? HardWareItemId { get; set; }
        public string DeviceName { get; set; }
        public string Comments { get; set; }
        public bool? Done { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }

        public virtual TwebwfItdelivered DeliveryNoNavigation { get; set; }
    }
}
