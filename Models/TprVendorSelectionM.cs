using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprVendorSelectionM
    {
        public TprVendorSelectionM()
        {
            TprVendorSelectionD = new HashSet<TprVendorSelectionD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public DateTime? Date { get; set; }
        public string Descrp { get; set; }
        public bool? MailSent { get; set; }
        public DateTime? MailSentDate { get; set; }
        public DateTime? DateRequest { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual ICollection<TprVendorSelectionD> TprVendorSelectionD { get; set; }
    }
}
