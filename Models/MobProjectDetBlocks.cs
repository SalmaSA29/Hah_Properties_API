using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MobProjectDetBlocks
    {
        public int DetBlockId { get; set; }
        public int DetAreaId { get; set; }
        public int BlId { get; set; }
        public string SuggClass { get; set; }
        public string DetBlockClass { get; set; }
        public string DetInUser { get; set; }
        public DateTime? DetInDate { get; set; }
        public string DetUpUser { get; set; }
        public DateTime? DetUpDate { get; set; }
    }
}
