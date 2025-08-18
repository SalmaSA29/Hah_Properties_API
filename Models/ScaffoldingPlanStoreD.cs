using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScaffoldingPlanStoreD
    {
        public int RecordId { get; set; }
        public string ProjectId { get; set; }
        public string SystemId { get; set; }
        public string StoreId { get; set; }
        public decimal? Value { get; set; }
        public DateTime? RequiredFrom { get; set; }
        public DateTime? ActualDateFrom { get; set; }
        public DateTime? ActualDateTo { get; set; }
        public decimal? ActualValue { get; set; }
        public string Comments { get; set; }

        public virtual ScaffoldingPlanStoreM Project { get; set; }
    }
}
