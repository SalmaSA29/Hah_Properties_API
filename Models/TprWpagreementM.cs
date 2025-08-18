using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprWpagreementM
    {
        public TprWpagreementM()
        {
            TprWpagreementD = new HashSet<TprWpagreementD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public DateTime? Date { get; set; }
        public string Descrp { get; set; }
        public double? Total { get; set; }
        public double? TotalCost { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public string CostControlUseComment { get; set; }
        public string AccountingNo { get; set; }
        public string ExpType { get; set; }
        public string PaymentCondition { get; set; }
        public string CostId { get; set; }

        public virtual ICollection<TprWpagreementD> TprWpagreementD { get; set; }
    }
}
