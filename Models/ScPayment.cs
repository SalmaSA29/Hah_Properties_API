using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScPayment
    {
        public ScPayment()
        {
            ScPaymentD = new HashSet<ScPaymentD>();
        }

        public int PaymentId { get; set; }
        public string InvoiceNo { get; set; }
        public string ProjectId { get; set; }
        public string SupplierId { get; set; }
        public string VendorName { get; set; }
        public int ScPaymentTypeId { get; set; }
        public string TypeOfWork { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? WorkDoneUpDate { get; set; }
        public double? CumulativeAmountWorkDone { get; set; }
        public double? AccPaymentAmount { get; set; }
        public double? ControlsPaymentAmount { get; set; }
        public double? OdPaymentAmount { get; set; }
        public double? FinalPaymentAmount { get; set; }
        public string Comments { get; set; }
        public string CommentAccount { get; set; }
        public string FileAttached { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
        public int? Status { get; set; }
        public bool? WithoutContract { get; set; }
        public string Contractno { get; set; }

        public virtual ICollection<ScPaymentD> ScPaymentD { get; set; }
    }
}
