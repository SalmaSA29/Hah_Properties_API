using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PurTsupplier
    {
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Prequalification { get; set; }
        public string TechnicalSpecsData { get; set; }
        public bool? Supplier { get; set; }
        public bool? SubContrcator { get; set; }
        public string VendorId { get; set; }
        public int? GovernorateId { get; set; }
        public int? RegionId { get; set; }
        public string Address { get; set; }
        public string CommercialRegistry { get; set; }
        public string TaxesCard { get; set; }
        public string FolderNum { get; set; }
        public string Direction { get; set; }
        public string Idnum { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public string CountryId { get; set; }
    }
}
