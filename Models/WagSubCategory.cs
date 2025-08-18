using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagSubCategory
    {
        public string SerialNo { get; set; }
        public string SubCategoryId { get; set; }
        public string MainCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string SubCategoryNameArabic { get; set; }
        public int? GroupPolicyId { get; set; }
        public string Type { get; set; }
        public double? MarketDailyRateAtTenderingStageMin { get; set; }
        public double? MarketDailyRateAtTenderingStageMax { get; set; }
        public double? MarketDailyRateAtTenderingStageMinWithoutTax { get; set; }
        public double? MarketDailyRateAtTenderingStageMaxWithoutTax { get; set; }
        public double? MarketDailyRateAtTenderingStageMaxBasicSelected { get; set; }
        public double? MarketDailyRateMin { get; set; }
        public double? MarketDailyRateMax { get; set; }
        public double? MarketDailyRateAvg { get; set; }
    }
}
