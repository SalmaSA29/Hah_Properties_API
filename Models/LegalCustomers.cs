using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class LegalCustomers
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string CustMobile { get; set; }
        public string CustPhone { get; set; }
        public string CustNationaid { get; set; }
        public int? JobId { get; set; }
        public string CustTawkel { get; set; }
        public DateTime? TawkelDate { get; set; }
        public string Realstate { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public int? Areacode { get; set; }
        public string Attachment { get; set; }
        public string Inuser { get; set; }
        public DateTime? Indate { get; set; }
        public string Upuser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
