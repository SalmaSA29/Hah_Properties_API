using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItphysicalM
    {
        public int PhysicalId { get; set; }
        public int? CountryId { get; set; }
        public string DepartmentId { get; set; }
        public int ProjectId { get; set; }
        public string Representative { get; set; }
        public DateTime? InDate { get; set; }
        public string CondName { get; set; }
        public int? GroupProject { get; set; }
        public int? LastEmailType { get; set; }
        public DateTime? LastEmailDate { get; set; }
    }
}
