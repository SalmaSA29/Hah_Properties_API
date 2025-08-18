using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PurchasingOrderM
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int DocNo { get; set; }
        public string PurchasOrderNo { get; set; }
        public DateTime? Date { get; set; }
        public string MrNo { get; set; }
        public double? BudgetForMr { get; set; }
        public double? ExpendedMrCost { get; set; }
        public double? Variance { get; set; }
        public string SensiorControlsManagerComment { get; set; }
        public string SensiorControlsManagerUserId { get; set; }
        public DateTime? SensiorControlsManagerDate { get; set; }
        public bool? PricesAreLogic { get; set; }
        public bool? ComparisonSheetIsAttached { get; set; }
        public bool? IstheRequiredMaterialIncluded { get; set; }
        public bool? OffersAreAttached { get; set; }
        public string ProcManagerComment { get; set; }
        public string ProcManagerUserId { get; set; }
        public DateTime? ProcManagerDate { get; set; }
        public bool? Stores { get; set; }
        public bool? OperationDirector { get; set; }
        public bool? SupportDiv { get; set; }
        public bool? CopyToControlAnalyst { get; set; }
        public bool? UpdateOnAreaTask { get; set; }
        public bool? Scanned { get; set; }
        public string ControlsAnalystUnitHeadComment { get; set; }
        public string ControlsAnalystUnitHeadUserId { get; set; }
        public DateTime? ControlsAnalystUnitHeadDate { get; set; }
        public string ProcAndControlsManagerComment { get; set; }
        public string ProcAndControlsManagerUserId { get; set; }
        public DateTime? ProcAndControlsManagerDate { get; set; }
        public string WhyIsRequired { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string Area { get; set; }
        public string DeliveryPeriod { get; set; }
        public string PaymentPercent { get; set; }
        public int? CachOrChq { get; set; }
        public string ChqNo { get; set; }
        public string Notes { get; set; }
    }
}
