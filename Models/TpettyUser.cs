using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TpettyUser
    {
        public string PettyUserId { get; set; }
        public string Name { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
