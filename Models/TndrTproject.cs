using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TndrTproject
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ParentId { get; set; }
        public bool? Main { get; set; }
        public string DbId { get; set; }
        public int? Levl { get; set; }
        public double? SellingValue { get; set; }
        public string CurrencyId { get; set; }
        public string CountryId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public bool? Mech { get; set; }
        public bool? Elec { get; set; }
        public bool? Industrial { get; set; }
        public bool? Em { get; set; }
        public bool? Ctv { get; set; }
        public bool? Isp { get; set; }
        public bool? Sa { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
