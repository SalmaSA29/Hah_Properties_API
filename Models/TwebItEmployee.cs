using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebItEmployee
    {
        public string UserHrCode { get; set; }
        public string DisplayName { get; set; }
        public bool? ServiceStatus { get; set; }
        public string WindowsAccount { get; set; }
        public string EmailAddress { get; set; }
        public string DeskPhone { get; set; }
        public bool? Internet { get; set; }
        public bool? UsbExceptions { get; set; }
        public bool? BbService { get; set; }
        public bool? Vbn { get; set; }
        public string PcOrLt { get; set; }
        public string PcName { get; set; }
        public bool? LocalPrinter { get; set; }
        public string PrinteerNu { get; set; }
        public string FullName { get; set; }
        public string ArabicName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidlleName { get; set; }
        public int? ItJobId { get; set; }
        public int? ItLocationId { get; set; }
        public int? ItGroupIdId { get; set; }
        public int? ItCompanyId { get; set; }
        public string OfficePhone { get; set; }
        public string TelephoneNumber { get; set; }
        public string Userprincipalname { get; set; }
    }
}
