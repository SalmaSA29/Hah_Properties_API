using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebHrProject
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManagerUser { get; set; }
        public string SecondLineUser { get; set; }
        public string HrUser { get; set; }
        public string ProjectCat { get; set; }
        public bool? Active { get; set; }
        public string ConcreteUser { get; set; }
    }
}
