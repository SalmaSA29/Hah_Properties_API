using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprTaskTemplate
    {
        public int TaskTemplateId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
