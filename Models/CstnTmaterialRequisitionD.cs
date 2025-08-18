using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnTmaterialRequisitionD
    {
        public int RecordId { get; set; }
        public string DocNo { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string UserId { get; set; }
        public int? StepNo { get; set; }
        public string Comments { get; set; }

        public virtual CstnTmaterialRequisition DocNoNavigation { get; set; }
    }
}
