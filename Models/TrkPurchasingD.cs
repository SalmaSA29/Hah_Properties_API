using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingD
    {
        public int MrDet { get; set; }
        public int MrId { get; set; }
        public int ApprovalId { get; set; }
        public DateTime? PlanningDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public string Comments { get; set; }
    }
}
