using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingQuotationM
    {
        public int RecordId { get; set; }
        public int? ProjectId { get; set; }
        public int? MrId { get; set; }
        public double? SupplierId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public int? RfqSerial { get; set; }
        public string DeliveryPeriod { get; set; }
        public string TermsofPayment { get; set; }
    }
}
