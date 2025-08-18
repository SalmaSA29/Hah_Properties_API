using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MobProjectM
    {
        public MobProjectM()
        {
            MobProjectDet = new HashSet<MobProjectDet>();
        }

        public int MobId { get; set; }
        public int ProjectCode { get; set; }
        public string ProClass { get; set; }
        public string ProFile { get; set; }
        public string ProDefinitionCode { get; set; }
        public string ProInUser { get; set; }
        public DateTime? ProInDate { get; set; }
        public string ProUpUser { get; set; }
        public DateTime? ProUpDate { get; set; }

        public virtual ICollection<MobProjectDet> MobProjectDet { get; set; }
    }
}
