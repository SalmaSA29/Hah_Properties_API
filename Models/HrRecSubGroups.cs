using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecSubGroups
    {
        public int SubGroupId { get; set; }
        public int? GroupId { get; set; }
        public string SubGroupName { get; set; }
    }
}
