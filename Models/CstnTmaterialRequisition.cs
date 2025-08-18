using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnTmaterialRequisition
    {
        public CstnTmaterialRequisition()
        {
            CstnTmaterialRequisitionD = new HashSet<CstnTmaterialRequisitionD>();
        }

        public string DocNo { get; set; }
        public string ProjectId { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string CostId { get; set; }
        public DateTime? Mrdate { get; set; }
        public bool? StoreApproval { get; set; }
        public bool? OperationApproval { get; set; }
        public bool? MrIsAttached { get; set; }
        public byte? HacFactoryScope { get; set; }
        public bool? PoIsAttached { get; set; }
        public bool? CompetitiveBid { get; set; }
        public bool? SoleSource { get; set; }
        public bool? ContractRequiredOrNot { get; set; }
        public bool? ClientSpecificApprovalOrNot { get; set; }
        public bool? ApprovedVONot { get; set; }
        public bool? FixedPriceAgreementOrNot { get; set; }
        public bool? Others { get; set; }
        public byte? MaterialCategory { get; set; }
        public byte? SubcontractorScope { get; set; }
        public decimal? BudgetQuantity { get; set; }
        public decimal? ActQuantity { get; set; }
        public decimal? LastForecast { get; set; }
        public decimal? ChangeInForecast { get; set; }
        public decimal? BudgetAmount { get; set; }
        public decimal? ActAmount { get; set; }
        public decimal? TotalBudget { get; set; }
        public bool? IfVoApproved { get; set; }
        public bool? IfVoApprovedConcept { get; set; }
        public bool? IfVoSubmitted { get; set; }
        public bool? IfVoRejected { get; set; }
        public bool? IfVoNotSubmittedYet { get; set; }
        public string VoLogSerial { get; set; }
        public byte? Assets { get; set; }
        public bool? ControlsAnalyst { get; set; }
        public bool? SupplyChainHead { get; set; }
        public bool? SupplyChainManager { get; set; }
        public bool? Procurement { get; set; }
        public bool? CostControlManager { get; set; }
        public bool? CostControlSenior { get; set; }
        public bool? Mdoperation { get; set; }
        public bool? ProcDirector { get; set; }
        public bool? Ceo { get; set; }
        public byte? CeoApproval { get; set; }
        public string PoNumber { get; set; }
        public DateTime? WhereHouseAprovalDate { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CstnTmaterialRequisitionD> CstnTmaterialRequisitionD { get; set; }
    }
}
