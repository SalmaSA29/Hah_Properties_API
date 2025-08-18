using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkProcurementD
    {
        public int Serial { get; set; }
        public int ProcurementId { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackage { get; set; }
        public int AgreementNo { get; set; }
        public int PrcMrApprovalId { get; set; }
        public DateTime? PlanningDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public string Comments { get; set; }

        public virtual TrkProcurement Procurement { get; set; }
    }
}
