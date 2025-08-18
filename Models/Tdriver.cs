using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Tdriver
    {
        public string DriverId { get; set; }
        public string DriverName { get; set; }
        public string JobId { get; set; }
        public string WorkLocation { get; set; }
        public string LicenseNo { get; set; }
        public string LicenseGrade { get; set; }
        public string Idcard { get; set; }
        public string MobileNo { get; set; }
        public DateTime? LicenseEndDate { get; set; }
        public bool? ResponsableAboutMoreThanEq { get; set; }
        public DateTime? WorkReceiptDate { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string HrCode { get; set; }
    }
}
