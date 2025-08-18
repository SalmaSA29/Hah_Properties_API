using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Tproject
    {
        public Tproject()
        {
            TjobOrderM = new HashSet<TjobOrderM>();
            TprTypeOfWorkProject = new HashSet<TprTypeOfWorkProject>();
            TprojectCurrency = new HashSet<TprojectCurrency>();
            TworkPackageProjet = new HashSet<TworkPackageProjet>();
        }

        public string ProjectId { get; set; }
        public string ProjectAccountId { get; set; }
        public string ProjectName { get; set; }
        public string ParentId { get; set; }
        public bool? Main { get; set; }
        public string DbId { get; set; }
        public int? Levl { get; set; }
        public DateTime? StartDate { get; set; }
        public string Months { get; set; }
        public string Weeks { get; set; }
        public string ConsultantId { get; set; }
        public string ClientId { get; set; }
        public DateTime? FinishDate { get; set; }
        public double? SellingValue { get; set; }
        public string ProcAndcontrolManager { get; set; }
        public string ControlsManager { get; set; }
        public string SeniorControlsManager { get; set; }
        public string ControlsEngineer { get; set; }
        public string UserRiskManager { get; set; }
        public string BudgetingManagerUserId { get; set; }
        public string CurrencyId { get; set; }
        public double? AdPaymentIdTeam { get; set; }
        public double? AdPaymentIdManager { get; set; }
        public double? RetentionIdTeam { get; set; }
        public double? RetentionIdManager { get; set; }
        public double? PaymentsondeliveryIdTeam { get; set; }
        public double? PaymentsondeliveryIdManager { get; set; }
        public string CountryId { get; set; }
        public int? FirstInvoiceYear { get; set; }
        public int? FirstInvoiceMonth { get; set; }
        public int? LastInvoiceYear { get; set; }
        public int? LastInvoiceMonth { get; set; }
        public int? TotaDeductions { get; set; }
        public int? ApprovalCycle { get; set; }
        public int? TotalPaidCycle { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId1 { get; set; }
        public string PartnershipTypeId { get; set; }
        public double? JvPerc { get; set; }
        public string ContactTypeTypeId { get; set; }
        public double? EstimatedGrossMargin { get; set; }
        public DateTime? AwardedDate { get; set; }
        public string ContractAdministrator { get; set; }
        public double? OriginalContractValue { get; set; }
        public double? CurrentContractValue { get; set; }
        public string RiskEngineer { get; set; }
        public string ProcManager { get; set; }
        public string LongLeadItemUser { get; set; }
        public string PlanningControlsManager { get; set; }
        public string SeniorPlanningControlsManager { get; set; }
        public string SupplyChainSectionHead { get; set; }
        public string SupplyChainSectionManager { get; set; }
        public string Mdoperation { get; set; }
        public string Ceo { get; set; }
        public double? ScDepreciationPercent { get; set; }
        public double? AcomTotalBudget { get; set; }
        public DateTime? AcomStartDate { get; set; }
        public DateTime? AcomEndDate { get; set; }
        public int? AcomCurrentPlanMonth { get; set; }
        public double? AcomCurrentPaidCost { get; set; }
        public double? AcomRemainingCost { get; set; }
        public string Dc { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectDirector { get; set; }
        public string OperationManager { get; set; }
        public string OdAssistant1 { get; set; }
        public string OdAssistant2 { get; set; }
        public string DepartmentId { get; set; }
        public string CostControlEngineer { get; set; }
        public string BudgetingEngineerUserId { get; set; }
        public string ControlsSeniorsEngineer { get; set; }
        public string SubContractingSeniorManager { get; set; }

        public virtual ICollection<TjobOrderM> TjobOrderM { get; set; }
        public virtual ICollection<TprTypeOfWorkProject> TprTypeOfWorkProject { get; set; }
        public virtual ICollection<TprojectCurrency> TprojectCurrency { get; set; }
        public virtual ICollection<TworkPackageProjet> TworkPackageProjet { get; set; }
    }
}
