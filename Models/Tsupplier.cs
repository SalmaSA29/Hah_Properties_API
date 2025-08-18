using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Tsupplier
    {
        public Tsupplier()
        {
            TsupplierContact = new HashSet<TsupplierContact>();
            TsupplierPhone = new HashSet<TsupplierPhone>();
            TsupplierTypeCodeD = new HashSet<TsupplierTypeCodeD>();
            TsupplierWorkPackage = new HashSet<TsupplierWorkPackage>();
        }

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
        public bool? QualifiedInNuclearProject { get; set; }
        public DateTime? QualifiedInNuclearProjectUpToDate { get; set; }
        public string QualifiedInNuclearProjectUpToDateComments { get; set; }
        public string SapId { get; set; }
        public string NameA { get; set; }
        public string NameE { get; set; }
        public int? HaHcoCode { get; set; }
        public bool? NeedSap { get; set; }
        public string Ranking { get; set; }
        public string Score { get; set; }
        public bool? Manufacturer { get; set; }
        public string Capital { get; set; }
        public string TypeofService { get; set; }
        public DateTime? InitialAcceptancedate { get; set; }
        public DateTime? LastAcceptancedate { get; set; }
        public DateTime? NextEvaluationdate { get; set; }
        public string MethodofEvaluation { get; set; }
        public string Remarks { get; set; }
        public DateTime? ExpireDate { get; set; }

        public virtual ICollection<TsupplierContact> TsupplierContact { get; set; }
        public virtual ICollection<TsupplierPhone> TsupplierPhone { get; set; }
        public virtual ICollection<TsupplierTypeCodeD> TsupplierTypeCodeD { get; set; }
        public virtual ICollection<TsupplierWorkPackage> TsupplierWorkPackage { get; set; }
    }
}
