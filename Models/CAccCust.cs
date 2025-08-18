using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CAccCust
    {
        public string AccId { get; set; }
        public string AccName { get; set; }
        public string ParentId { get; set; }
        public string ChildId { get; set; }
        public bool Main { get; set; }
        public bool? IsMain { get; set; }
        public byte Levl { get; set; }
        public string TypesAcc { get; set; }
        public string AutoPrePaidContCust { get; set; }
        public string AutoPrePaidContCustName { get; set; }
        public bool? AutoPrePaidContCustChk { get; set; }
        public string AutoInsuranceConCust { get; set; }
        public string AutoInsuranceConCustName { get; set; }
        public bool? AutoInsuranceConCustChk { get; set; }
        public string AutoTempDeduct { get; set; }
        public string AutoTempDeductName { get; set; }
        public bool? AutoTempDeductChk { get; set; }
        public string AutoStorage { get; set; }
        public string AutoStorageName { get; set; }
        public bool? AutoStorageChk { get; set; }
        public string AutoMkcust { get; set; }
        public string AutoMkcustName { get; set; }
        public bool? AutoMkcustChk { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Fax { get; set; }
        public string ContectPerson { get; set; }
        public string ContectPerson1 { get; set; }
        public string ContectPerson2 { get; set; }
        public decimal? CreditVal { get; set; }
        public decimal? CreditPers { get; set; }
        public string TaxFileNoG { get; set; }
        public bool? Taxable { get; set; }
        public string TaxPlaceNameG { get; set; }
        public string TaxFileNoS { get; set; }
        public string TaxPlaceNameS { get; set; }
        public string GroupCustMId { get; set; }
        public string GroupCustSId { get; set; }
        public string CurrIdd { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }
    }
}
