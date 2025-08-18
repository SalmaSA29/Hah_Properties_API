using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItrequestContract
    {
        public int RequestNo { get; set; }
        public string ServiceId { get; set; }
        public string ProjectId { get; set; }
        public string RequestHrCode { get; set; }
        public int? ContractNo { get; set; }
        public DateTime? Date { get; set; }
        public int? InvoiceNo { get; set; }
        public double? Amount { get; set; }
        public int? Currency { get; set; }
        public bool? Paid { get; set; }
        public double? Rate { get; set; }
        public int? Paymenttype { get; set; }
        public bool? Confirm1 { get; set; }
        public string Confirm1User { get; set; }
        public DateTime? Confirm1UserDate { get; set; }
        public bool? Confirm2 { get; set; }
        public string Confirm2User { get; set; }
        public DateTime? Confirm2UserDate { get; set; }
        public bool? Confirm3 { get; set; }
        public string Confirm3User { get; set; }
        public DateTime? Confirm3UserDate { get; set; }
        public string Comment { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public string RejectedHrCode { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? ReRequestCode { get; set; }
        public int? Status { get; set; }
    }
}
