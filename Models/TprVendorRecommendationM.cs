using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprVendorRecommendationM
    {
        public TprVendorRecommendationM()
        {
            TprVendorRecommendationClientD = new HashSet<TprVendorRecommendationClientD>();
            TprVendorRecommendationCompanyD = new HashSet<TprVendorRecommendationCompanyD>();
            TprVendorRecommendationEvalD = new HashSet<TprVendorRecommendationEvalD>();
            TprVendorRecommendationTenderD = new HashSet<TprVendorRecommendationTenderD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public DateTime? Date { get; set; }
        public string Descrp { get; set; }
        public bool? MailSent { get; set; }
        public DateTime? MailSentDate { get; set; }
        public DateTime? DateRequest { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual ICollection<TprVendorRecommendationClientD> TprVendorRecommendationClientD { get; set; }
        public virtual ICollection<TprVendorRecommendationCompanyD> TprVendorRecommendationCompanyD { get; set; }
        public virtual ICollection<TprVendorRecommendationEvalD> TprVendorRecommendationEvalD { get; set; }
        public virtual ICollection<TprVendorRecommendationTenderD> TprVendorRecommendationTenderD { get; set; }
    }
}
