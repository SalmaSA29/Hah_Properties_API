using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstStoreDataD
    {
        public string ProjectId { get; set; }
        public int RecordId { get; set; }
        public DateTime? Date { get; set; }
        public string MaterialId { get; set; }
        public string Source { get; set; }
        public string Unit { get; set; }
        public int? Vo { get; set; }
        public double? Qty { get; set; }
        public double? UnitRate { get; set; }
        public string Comments { get; set; }

        public virtual CstStoreDataM Project { get; set; }
    }
}
