using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprTaskUserComments
    {
        public int RecordId { get; set; }
        public int TaskId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UserComments { get; set; }

        public virtual TprTask Task { get; set; }
    }
}
