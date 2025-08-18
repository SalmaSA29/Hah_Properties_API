using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecGroups
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int? DepartmentId { get; set; }
    }
}
