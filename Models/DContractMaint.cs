using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class DContractMaint
    {
        public byte ContractMaintId { get; set; }
        public int ContractNo { get; set; }
        public string CustId { get; set; }
        public string CustName { get; set; }
        public DateTime Date { get; set; }
        public string ItemId { get; set; }
        public string ModelId { get; set; }
        public string SerialNumber { get; set; }
        public string FiscalYear { get; set; }
        public int? PreventiveVisitsNo { get; set; }
        public int? EmergencyVisitsNo { get; set; }
        public decimal? VisitVal { get; set; }
        public decimal? ContractVal { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool? AutoRenewed { get; set; }
        public bool? TerminateContract { get; set; }
        public string ContractRtf { get; set; }
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
    }
}
