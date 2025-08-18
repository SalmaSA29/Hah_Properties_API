using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TypesAcc
    {
        public string TypesAcc1 { get; set; }
        public string TypesName { get; set; }
        public string TypesNameEn { get; set; }
        public string MdlName { get; set; }
        public string ParentTypes { get; set; }
        public bool? MainAcc { get; set; }
        public bool? CheckCurrency { get; set; }
        public bool? MainCurrencyOnly { get; set; }
        public byte? AccNature { get; set; }
        public bool? CanAddSubInGeneral { get; set; }
        public bool? MustChoseTypes { get; set; }
        public bool? MustBeSubMain { get; set; }
        public bool Inherited { get; set; }
        public bool BalanceAcc { get; set; }
        public bool IncomeAcc { get; set; }
        public string ClassificationIncomeStatement { get; set; }
        public bool? BGeneral { get; set; }
        public bool? ShowTaxData { get; set; }
        public bool? UseInEntry { get; set; }
        public bool? IsAsset { get; set; }
        public bool? IsAutoAccumulatedDep { get; set; }
        public bool? IsAutoExpDep { get; set; }
        public bool? IsStock { get; set; }
        public bool? IsAutoCostMtr { get; set; }
        public bool? IsAutoSales { get; set; }
        public bool? IsAutoConsignment { get; set; }
        public bool? IsCustCom { get; set; }
        public bool? IsCustCont { get; set; }
        public bool? IsCustMk { get; set; }
        public bool? IsCostImport { get; set; }
        public bool? IsAutoPrePaidCustCont { get; set; }
        public bool? IsAutoInsuranceCustCon { get; set; }
        public bool? IsAutoTempDeductCustCont { get; set; }
        public bool? IsAutoStorageCustCont { get; set; }
        public bool? IsAutoMkcust { get; set; }
        public bool? IsSupp { get; set; }
        public bool? IsSuppCont { get; set; }
        public bool? IsAutoPrePaidContSupp { get; set; }
        public bool? IsAutoInsuranceConSupp { get; set; }
        public bool? IsAutoTempDeduct { get; set; }
        public bool? IsAutoStorageContSupp { get; set; }
        public bool? IsAccCash { get; set; }
        public bool? IsAccCashSlandPurshase { get; set; }
        public bool? IsReceNots { get; set; }
        public bool? IsPayNots { get; set; }
        public bool? IsBank { get; set; }
        public bool? IsTaxDeductForOth { get; set; }
        public bool? IsTaxDeductForComp { get; set; }
        public bool? IsTaxSales { get; set; }
        public bool? IsExpenses { get; set; }
        public bool? IsExChangeDb { get; set; }
        public bool? IsCostCont { get; set; }
        public bool? IsExpCont { get; set; }
        public bool? IsWorkUnderCont { get; set; }
        public bool? IsWorkUnderContCont { get; set; }
        public bool? IsWorkUnderContMtr { get; set; }
        public bool? IsWorkUnderContExp { get; set; }
        public bool? IsRevenue { get; set; }
        public bool? IsSales { get; set; }
        public bool? IsRevenueCont { get; set; }
        public bool? IsOthSales { get; set; }
        public bool? IsExChangeCr { get; set; }
        public bool? IsPandLPeriod { get; set; }
        public bool? IsPandLAccumulated { get; set; }
        public bool? IsProvCust { get; set; }
        public bool? IsProvStc { get; set; }
        public bool? IsProvGarnty { get; set; }
        public bool? IsPrePaidExp { get; set; }
        public bool? IsAccuredExp { get; set; }
        public bool? IsFollowAcc { get; set; }
        public bool? IsAccDeduct { get; set; }
        public bool? IsAccSuppCont { get; set; }
        public bool? IsChangesInInventories { get; set; }
        public bool? IsPrepaidRev { get; set; }
    }
}
