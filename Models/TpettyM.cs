using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TpettyM
    {
        public TpettyM()
        {
            TpettyD = new HashSet<TpettyD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string PettyNo { get; set; }
        public DateTime? Date { get; set; }
        public string PettyUserId { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public DateTime? LocalRplDate { get; set; }
        public bool? CanUpd { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<TpettyD> TpettyD { get; set; }
    }
}
