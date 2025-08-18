using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MobAreas
    {
        public int ArId { get; set; }
        public int? Serial { get; set; }
        public string ClId { get; set; }
        public string ArName { get; set; }
        public string ArFile { get; set; }
        public bool? HaveBlocks { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
