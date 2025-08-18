using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstTtask
    {
        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public string DivisionId { get; set; }
        public string Unit { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
