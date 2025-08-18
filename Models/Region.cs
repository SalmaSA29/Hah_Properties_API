using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Region
    {
        public int? GovernorateId { get; set; }
        public int RegionId { get; set; }
        public string Region1 { get; set; }

        public virtual Governorate Governorate { get; set; }
    }
}
