using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SdmTasks
    {
        public int TaskId { get; set; }
        public int? ReqId { get; set; }
        public int? ProjectId { get; set; }
        public int? ResourceId { get; set; }
        public string TaskName { get; set; }
        public string TaskDesc { get; set; }
        public double? TaskDuration { get; set; }
        public DateTime? TaskDeadline { get; set; }
        public int? Priority { get; set; }
        public int? Status { get; set; }
        public int? TaskTypeId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }

        public virtual SdmProjects Project { get; set; }
    }
}
