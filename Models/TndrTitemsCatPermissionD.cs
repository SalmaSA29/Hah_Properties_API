using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TndrTitemsCatPermissionD
    {
        public string UserId { get; set; }
        public string DepId { get; set; }
        public string ProjectId { get; set; }
        public string SubCatId { get; set; }
        public string Comments { get; set; }

        public virtual TndrTitemsCatPermissionM TndrTitemsCatPermissionM { get; set; }
    }
}
