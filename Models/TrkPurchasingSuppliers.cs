using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingSuppliers
    {
        public double? AlphaCode { get; set; }
        public double SapCode { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string MobilePhone { get; set; }
        public string EMail { get; set; }
    }
}
