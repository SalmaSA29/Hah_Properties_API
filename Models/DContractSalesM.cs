using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class DContractSalesM
    {
        public byte DocId { get; set; }
        public int ContractNo { get; set; }
        public string FiscalYear { get; set; }
        public DateTime Date { get; set; }
        public int? OfferNo { get; set; }
        public int? NotifyContractNo { get; set; }
        public string CurrencyId { get; set; }
        public decimal Rate { get; set; }
        public string CustId { get; set; }
        public string CustName { get; set; }
        public string PolicyId { get; set; }
        public string DeliveryPeriod { get; set; }
        public string ReceivePlace { get; set; }
        public decimal? DiscountPerc { get; set; }
        public string SalesMenId { get; set; }
        public string UserId { get; set; }
        public string PassWord { get; set; }
        public decimal? Val { get; set; }
        public decimal? Vcurr { get; set; }
        public string ContractRtf { get; set; }
        public bool Checked { get; set; }
        public bool Closed { get; set; }
        public bool Pricing { get; set; }
        public bool ExitPricing { get; set; }
        public bool? Confirm1 { get; set; }
        public bool? Confirm2 { get; set; }
        public bool? Confirm3 { get; set; }
        public bool? Confirm4 { get; set; }
        public bool? Confirm5 { get; set; }
        public bool? Confirm6 { get; set; }
        public string Confirm1User { get; set; }
        public string Confirm2User { get; set; }
        public string Confirm3User { get; set; }
        public string Confirm4User { get; set; }
        public string Confirm5User { get; set; }
        public string Confirm6User { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public DateTime? LocalRplDate { get; set; }
        public bool? CanUpd { get; set; }

        public virtual Currency Currency { get; set; }
    }
}
