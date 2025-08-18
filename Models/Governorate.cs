using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Governorate
    {
        public Governorate()
        {
            Region = new HashSet<Region>();
        }

        public int GovernorateId { get; set; }
        public string GovernorateEng { get; set; }
        public string GovernorateAr { get; set; }

        public virtual ICollection<Region> Region { get; set; }
    }
}
