using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PurSupplyOrderM
    {
        public PurSupplyOrderM()
        {
            PurSupplyOrderD = new HashSet<PurSupplyOrderD>();
        }

        public int DocNo { get; set; }
        public string SupplierId { get; set; }
        public string ProjectId { get; set; }
        public DateTime? Date { get; set; }
        public string Comments { get; set; }
        public string Posting { get; set; }
        public string PostingNo { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual ICollection<PurSupplyOrderD> PurSupplyOrderD { get; set; }
    }
}
