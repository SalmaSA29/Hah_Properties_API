using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MobClass
    {
        public string ClId { get; set; }
        public string ClFile { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
