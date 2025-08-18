using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfItincludePrD
    {
        public int IncludeDetId { get; set; }
        public int IncludeId { get; set; }
        public int? RequestNo { get; set; }
        public string HardWareItemId { get; set; }
        public string OwnerHrCode { get; set; }
        public int? Qty { get; set; }
        public bool? Chk { get; set; }
        public double? EstimatePrice { get; set; }
        public bool? Approved { get; set; }
        public string RejectedHrCode { get; set; }
        public int? RecordId { get; set; }

        public virtual TwebwfItincludePr Include { get; set; }
    }
}
