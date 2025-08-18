using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SaphrCodingRequestsD
    {
        public int ReqDet { get; set; }
        public int ReqId { get; set; }
        public int? CompanyId { get; set; }
        public int? AllocationId { get; set; }
        public int? AreaId { get; set; }
        public int? UnitId { get; set; }
        public int? SubTypeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? PositionId { get; set; }
        public int? Count { get; set; }
        public string SapCode { get; set; }
        public string HrCode { get; set; }
        public string SapIncodeUser { get; set; }
        public DateTime? SapIndate { get; set; }
        public bool? StatusD { get; set; }

        public virtual SaphrCodingRequests Req { get; set; }
    }
}
