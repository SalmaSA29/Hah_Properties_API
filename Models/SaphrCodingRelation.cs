using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SaphrCodingRelation
    {
        public int RelDepId { get; set; }
        public int? CompanyId { get; set; }
        public int? AllocationId { get; set; }
        public int? AreaId { get; set; }
        public int? DepartmentId { get; set; }
        public int? UnitId { get; set; }
        public int? SubTypeId { get; set; }
        public int? PositionId { get; set; }
        public int? GroupPos { get; set; }
        public int? GroupUnit { get; set; }
    }
}
