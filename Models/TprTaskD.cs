using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprTaskD
    {
        public int TaskId { get; set; }
        public string UserId { get; set; }
        public bool Done { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual TprTask Task { get; set; }
    }
}
