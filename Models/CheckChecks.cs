using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CheckChecks
    {
        public int ExchId { get; set; }
        public string TrkSys { get; set; }
        public int? TrkId { get; set; }
        public string VendId { get; set; }
        public string VendName { get; set; }
        public string ProCode { get; set; }
        public double? Amount { get; set; }
        public string WordAmount { get; set; }
        public int? PaymentTypeId { get; set; }
        public string ExchDesc { get; set; }
        public int? CurrencyId { get; set; }
        public string ContrcatNo { get; set; }
        public int? BankId { get; set; }
        public DateTime? CheckDate { get; set; }
        public string CheckNo { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? DelivereDate { get; set; }
        public bool? IsPrented { get; set; }
        public bool? IsCanceled { get; set; }
        public bool? IsHold { get; set; }
        public int? Status { get; set; }
        public int? PoolMasterCode { get; set; }
        public bool? InPool { get; set; }
        public string UserPool { get; set; }
        public DateTime? DatePool { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string CheckInUser { get; set; }
        public DateTime? CheckInDate { get; set; }
    }
}
