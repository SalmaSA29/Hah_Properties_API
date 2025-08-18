using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprAanApprovalManual
    {
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public int DocNo { get; set; }
        public DateTime? Date { get; set; }
        public string Descrp { get; set; }
        public string ExpType { get; set; }
        public string SupplierId { get; set; }
        public double? Adpayment { get; set; }
        public double? Retenation { get; set; }
        public double? CurrentBudget { get; set; }
        public double? OnDelivery { get; set; }
        public double? FinalPrice { get; set; }
        public int? ItemOverBudget { get; set; }
        public int? ItemUnderBudget { get; set; }
        public string ItemDescription { get; set; }
        public string ExpTypeActual { get; set; }
        public bool? TermsOfPayment { get; set; }
        public bool? CurrentBudget1 { get; set; }
        public bool? Expetation { get; set; }
        public string CostControlUnitHead { get; set; }
        public string CostControlManager { get; set; }
        public string ContractManager { get; set; }
        public string ProcUnitHead { get; set; }
        public string ProcEngineer { get; set; }
        public string ProcManager { get; set; }
        public DateTime? CostControlUnitHeadDate { get; set; }
        public DateTime? CostControlManagerDate { get; set; }
        public DateTime? ContractManagerDate { get; set; }
        public DateTime? ProcUnitHeadDate { get; set; }
        public DateTime? ProcEngineerDate { get; set; }
        public DateTime? ProcManagerDate { get; set; }
        public double? MonthlyPayment { get; set; }
        public double? ActualWorkDone { get; set; }
        public double? TotalCashPaid { get; set; }
        public double? TotalGuarantees { get; set; }
        public double? PerformanceBond { get; set; }
        public double? AdPaymentRecovery { get; set; }
        public string BudgetFinancialControlsManagerComment { get; set; }
        public byte? QuantitiesNotExceedTheRemaining { get; set; }
        public byte? ScopQtyDoesntAwardedBefore { get; set; }
        public byte? NewScopeIdOrOnAccountOfSubcontractor { get; set; }
        public string MainScopeId { get; set; }
        public bool? MainScope { get; set; }
        public int? OnAccountOfSubcontractorSupplierId { get; set; }
        public string DueTo { get; set; }
        public string ControlsManagerComment { get; set; }
        public string ProEngineerUserId { get; set; }
        public string ControlsManagerUserId { get; set; }
        public string SensiorControlsManagerUserId { get; set; }
        public string ProcManagerUserId { get; set; }
        public string ProcControlManagerUserId { get; set; }
        public DateTime? ProEngineerDate { get; set; }
        public DateTime? ControlsManagerDate { get; set; }
        public DateTime? SensiorControlsManagerDate { get; set; }
        public DateTime? ProcManagerDate1 { get; set; }
        public DateTime? ProcControlManagerDate { get; set; }
        public string ProcAndControlsManagerComment { get; set; }
        public string ProcurementManagerComment { get; set; }
        public double? AmountToBeDeductedFromOtherVendors { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public int? AdPaymentAgainst { get; set; }
        public int? PerofrmanceBond { get; set; }
        public double? ContractualValue { get; set; }
        public double? BudgetValue { get; set; }
    }
}
