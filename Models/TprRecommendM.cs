using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprRecommendM
    {
        public TprRecommendM()
        {
            TprRecommendClientD = new HashSet<TprRecommendClientD>();
            TprRecommendTenderD = new HashSet<TprRecommendTenderD>();
        }

        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public DateTime? Date { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public string Descrp { get; set; }

        public virtual ICollection<TprRecommendClientD> TprRecommendClientD { get; set; }
        public virtual ICollection<TprRecommendTenderD> TprRecommendTenderD { get; set; }
    }
}
