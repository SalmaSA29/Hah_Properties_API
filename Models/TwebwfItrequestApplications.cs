using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItrequestApplications
    {
        public TwebwfItrequestApplications()
        {
            TwebwfItrequestApplicationsD = new HashSet<TwebwfItrequestApplicationsD>();
        }

        public int RequestNo { get; set; }
        public string ServiceId { get; set; }
        public string ProjectId { get; set; }
        public string RequestHrCode { get; set; }
        public DateTime? Date { get; set; }
        public string OwnerHrCode { get; set; }
        public string OwnerFullName { get; set; }
        public string OwnerTitle { get; set; }
        public string OwnerLocation { get; set; }
        public string OwnerMobile { get; set; }
        public string OwnerGroupPermission { get; set; }
        public string Comments { get; set; }
        public int? Status { get; set; }
        public string RejectedHrCode { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? ReqType { get; set; }
        public string AnswerEmail { get; set; }
        public bool? AIS { get; set; }
        public bool? HAHPortal { get; set; }
        public bool? HR { get; set; }
        public bool? ConcreteApp { get; set; }
        public bool? ScaffoldingApp { get; set; }
        public virtual ICollection<TwebwfItrequestApplicationsD> TwebwfItrequestApplicationsD { get; set; }
    }
}
