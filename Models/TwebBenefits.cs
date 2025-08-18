using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebBenefits
    {
        public int BenefitsId { get; set; }
        public string BenefitsName { get; set; }
        public string BenefitsDescription { get; set; }
        public string DiscountPercent { get; set; }
        public string DiscountType { get; set; }
        public int? CatId { get; set; }
        public string BenefitsDescriptionShort { get; set; }
        public string FileName { get; set; }
    }
}
