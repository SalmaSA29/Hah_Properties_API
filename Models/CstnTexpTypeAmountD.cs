using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnTexpTypeAmountD
    {
        public string ExpType { get; set; }
        public string ProjectId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public double? Amount { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual CstnTexpTypeAmountM CstnTexpTypeAmountM { get; set; }
    }
}
