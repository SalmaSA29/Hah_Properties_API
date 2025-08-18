using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanRequestForQoutation
    {
        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public bool? MailToSuppliers { get; set; }
        public bool? MailToContControl { get; set; }
        public bool? MailToPlanning { get; set; }
        public DateTime? Date { get; set; }
        public string Descrp { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
