using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItrequestAccessRight
    {
        public TwebwfItrequestAccessRight()
        {
            TwebwfItrequestAccessRightD = new HashSet<TwebwfItrequestAccessRightD>();
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
        public string OwnerEmailDisabled { get; set; }
        public string FilePdf { get; set; }
        public string Comments { get; set; }
        public int? Status { get; set; }
        public string RejectedHrCode { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? ReRequestCode { get; set; }
        public int? ReqType { get; set; }
        public string AnswerEmail { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsPermanent { get; set; }
        public bool? USBException { get; set; }
        public bool? VPNAccount { get; set; }
        public bool? IPPhone { get; set; }
        public bool? LocalAdmin { get; set; }
        public bool? LoginUserAccount { get; set; }
        public bool? EmailAccount { get; set; }
        public bool? Printing { get; set; }
        public bool? IsSolved { get; set; }
        public virtual ICollection<TwebwfItrequestAccessRightD> TwebwfItrequestAccessRightD { get; set; }
    }
}
