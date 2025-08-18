using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebProjects
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
    }
}
