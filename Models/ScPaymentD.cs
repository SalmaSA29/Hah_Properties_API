using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScPaymentD
    {
        public int Serial { get; set; }
        public int PaymentId { get; set; }
        public string InvoiceNo { get; set; }
        public string ProjectId { get; set; }
        public string SupplierId { get; set; }
        public int? ScPaymentApprovalId { get; set; }
        public DateTime? PlanningDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public string Comments { get; set; }

        public virtual ScPayment Payment { get; set; }
    }
}
