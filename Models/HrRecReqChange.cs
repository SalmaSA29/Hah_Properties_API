using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecReqChange
    {
        public int ChId { get; set; }
        public int? ChangeType { get; set; }
        public string ChRequester { get; set; }
        public int? ChInterviewId { get; set; }
        public string ChHrcode { get; set; }
        public int? ChCurrentTitle { get; set; }
        public string ChCurrentSalary { get; set; }
        public int? ChHacExpr { get; set; }
        public int? ChAllExpr { get; set; }
        public string ChCurrentDesc { get; set; }
        public int? ChNewTitle { get; set; }
        public int? ChNewSalary { get; set; }
        public string ChNewDesc { get; set; }
        public DateTime? ChActionDate { get; set; }
        public DateTime? InDate { get; set; }
        public string ConfHr { get; set; }
        public DateTime? ConfHrDate { get; set; }
        public string ConfDirectManager { get; set; }
        public string ConfOperation { get; set; }
        public int? Status { get; set; }
    }
}
