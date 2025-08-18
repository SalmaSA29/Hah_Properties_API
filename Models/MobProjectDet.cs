using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MobProjectDet
    {
        public int DetAreaId { get; set; }
        public int MobId { get; set; }
        public int ArId { get; set; }
        public string DetAreaClass { get; set; }
        public string DetAreaFile { get; set; }
        public string DetInUser { get; set; }
        public DateTime? DetInDate { get; set; }
        public string DetUpUser { get; set; }
        public DateTime? DetUpDate { get; set; }

        public virtual MobProjectM Mob { get; set; }
    }
}
