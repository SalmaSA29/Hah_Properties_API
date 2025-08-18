using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstNewAgreementM
    {
        public CstNewAgreementM()
        {
            CstNewAgreementD = new HashSet<CstNewAgreementD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string SupplierId { get; set; }
        public DateTime? Date { get; set; }
        public string Descrp { get; set; }
        public double? AggTotalCost { get; set; }
        public double? TotalCost { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public string CostControlUseComment { get; set; }
        public string AccountingNo { get; set; }
        public string ExpType { get; set; }
        public string ExpTypeActual { get; set; }
        public string PaymentCondition { get; set; }
        public int? AgreementNo { get; set; }

        public virtual ICollection<CstNewAgreementD> CstNewAgreementD { get; set; }
    }
}
