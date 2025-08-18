using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingPoM
    {
        public int PoId { get; set; }
        public string PoNo { get; set; }
        public DateTime? PoDate { get; set; }
        public double? SupplierId { get; set; }
        public string TotalAmount { get; set; }
        public int? GroupId { get; set; }
        public int? MrId { get; set; }
        public string Comment { get; set; }
        public string PoAttach { get; set; }
        public string RePoAttach { get; set; }
        public string PoApAmountCur { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string PaymentTerms { get; set; }
        public string DelieveryTerms { get; set; }
        public string SpecialTerms { get; set; }
    }
}
