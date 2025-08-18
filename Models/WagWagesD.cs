using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagWagesD
    {
        public int RecordId { get; set; }
        public int DocNo { get; set; }
        public string EmployeeNo { get; set; }
        public int? FromHour { get; set; }
        public int? ToHour { get; set; }
        public string CostCode { get; set; }
        public string RegionCode { get; set; }
        public string BuildingCode { get; set; }
        public string SegmentCode { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }

        public virtual WagWagesM DocNoNavigation { get; set; }
    }
}
