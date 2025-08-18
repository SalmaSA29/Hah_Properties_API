using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PublicMobilesData
    {
        public int MobId { get; set; }
        public string UserHrCode { get; set; }
        public string FullName { get; set; }
        public string MobNationalId { get; set; }
        public string MobMobProvider { get; set; }
        public string MobMobNo { get; set; }
        public string MobDataProvider { get; set; }
        public string MobDataNo { get; set; }
        public string Location { get; set; }
        public string TitleId { get; set; }
        public string PersonalMob1 { get; set; }
        public string Email { get; set; }
    }
}
