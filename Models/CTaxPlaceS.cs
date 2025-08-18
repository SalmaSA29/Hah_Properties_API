using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CTaxPlaceS
    {
        public string TaxPlaceNameS { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }

        public virtual CDb Db { get; set; }
    }
}
