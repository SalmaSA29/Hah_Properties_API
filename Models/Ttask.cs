using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Ttask
    {
        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskNameE { get; set; }
        public string BusinessTypeId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
