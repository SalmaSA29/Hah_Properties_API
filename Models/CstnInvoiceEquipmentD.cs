using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstnInvoiceEquipmentD
    {
        public string ProjectId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string CostId { get; set; }
        public decimal? TotalCost { get; set; }
        public string Comments { get; set; }

        public virtual CstnInvoiceEquipmentM CstnInvoiceEquipmentM { get; set; }
    }
}
