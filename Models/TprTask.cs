using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprTask
    {
        public TprTask()
        {
            TprTaskD = new HashSet<TprTaskD>();
            TprTaskUserComments = new HashSet<TprTaskUserComments>();
        }

        public int TaskId { get; set; }
        public int? DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string UserComments { get; set; }
        public DateTime Deadline { get; set; }
        public double? ManHour { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public byte Done { get; set; }

        public virtual ICollection<TprTaskD> TprTaskD { get; set; }
        public virtual ICollection<TprTaskUserComments> TprTaskUserComments { get; set; }
    }
}
