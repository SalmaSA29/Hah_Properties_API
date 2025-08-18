using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlan
    {
        public TprPlan()
        {
            TprPlanD = new HashSet<TprPlanD>();
            TprPlanUsers = new HashSet<TprPlanUsers>();
            TprWpagreementManualD = new HashSet<TprWpagreementManualD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string TeamLeaderUserId { get; set; }
        public string EngineerUserId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? EndDateOnSite { get; set; }
        public bool? IsLongLead { get; set; }
        public DateTime? MrReceivedDate { get; set; }
        public string MrMrcode { get; set; }
        public string Descrp { get; set; }
        public string AggrementName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public string AccountingNo { get; set; }
        public string ExpType { get; set; }
        public string PaymentCondition { get; set; }
        public bool? Submit { get; set; }
        public bool? Approved { get; set; }
        public bool? Approved1 { get; set; }
        public int? AgreementNo { get; set; }
        public string PlanningControlsManager { get; set; }
        public DateTime? OldDate { get; set; }
        public int? PlanType { get; set; }
        public int? OldAgreement { get; set; }
        public string SupplierId { get; set; }
        public string ContractNo { get; set; }
        public bool? Isprocurement { get; set; }
        public string SeniorProcManager { get; set; }
        public int? ReferAgreement { get; set; }
        public bool? FixedFlag { get; set; }

        public virtual ICollection<TprPlanD> TprPlanD { get; set; }
        public virtual ICollection<TprPlanUsers> TprPlanUsers { get; set; }
        public virtual ICollection<TprWpagreementManualD> TprWpagreementManualD { get; set; }
    }
}
