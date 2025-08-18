using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Currency
    {
        public Currency()
        {
            DContractSalesM = new HashSet<DContractSalesM>();
        }

        public string CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySubName { get; set; }
        public bool? Main { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }
        public string Shortcut { get; set; }

        public virtual CDb Db { get; set; }
        public virtual ICollection<DContractSalesM> DContractSalesM { get; set; }
    }
}
