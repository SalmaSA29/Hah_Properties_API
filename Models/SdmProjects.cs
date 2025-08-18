using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SdmProjects
    {
        public SdmProjects()
        {
            SdmTasks = new HashSet<SdmTasks>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string RequesterHrcode { get; set; }
        public DateTime? InitiationDate { get; set; }
        public DateTime? RequestDate { get; set; }
        public int? Priority { get; set; }
        public string ScopeOfWork { get; set; }
        public string NeededBusiness { get; set; }
        public string NeededItResources { get; set; }
        public string AssignedToHrcode { get; set; }
        public DateTime? DeadLine { get; set; }
        public int? EstimatedTime { get; set; }
        public int? Status { get; set; }
        public int? Color { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }

        public virtual ICollection<SdmTasks> SdmTasks { get; set; }
    }
}
