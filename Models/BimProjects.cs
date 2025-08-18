using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class BimProjects
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpdUser { get; set; }
        public DateTime? UpdDate { get; set; }
    }
}
