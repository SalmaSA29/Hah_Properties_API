using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnItemsExecutedByDD
    {
        public string ProjectId { get; set; }
        public string ItemNo { get; set; }
        public int AreaNo { get; set; }
        public int AgreementNo { get; set; }
        public double AgreementPer { get; set; }
        public string Comments { get; set; }

        public virtual CstnItemsExecutedByD CstnItemsExecutedByD { get; set; }
    }
}
