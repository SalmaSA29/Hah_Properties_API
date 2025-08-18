using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItContractM
    {
        public int ContractNo { get; set; }
        public string Pono { get; set; }
        public string ContractType { get; set; }
        public string Description { get; set; }
        public string PaymentType { get; set; }
        public long? SupplierId { get; set; }
        public double? Amount { get; set; }
        public int? Currency { get; set; }
        public int? Status { get; set; }
        public string Attachment { get; set; }
        public string Itarea { get; set; }
        public int? Costelement { get; set; }
        public int? Sites { get; set; }
        public DateTime? Datefrom { get; set; }
        public DateTime? Dateto { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUser { get; set; }
        public bool? PayInEgypt { get; set; }
        public string BudgetType { get; set; }
        public string Requestno { get; set; }
        public bool? Paydistrip { get; set; }
        public string Comment { get; set; }
    }
}
