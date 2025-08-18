using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TworkPackageNewWithCode
    {
        public int Serial { get; set; }
        public string WorkPackageId { get; set; }
        public string WorkGroupId { get; set; }
        public string WorkTypeId { get; set; }
        public string NewName { get; set; }
        public string DisciplineCodeNew { get; set; }
        public string NewCode { get; set; }
    }
}
