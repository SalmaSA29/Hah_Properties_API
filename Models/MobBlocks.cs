using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MobBlocks
    {
        public int BlId { get; set; }
        public int ArId { get; set; }
        public int? Serial { get; set; }
        public string BlName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
