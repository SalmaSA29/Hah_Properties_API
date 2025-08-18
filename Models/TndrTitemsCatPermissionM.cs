using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TndrTitemsCatPermissionM
    {
        public TndrTitemsCatPermissionM()
        {
            TndrTitemsCatPermissionD = new HashSet<TndrTitemsCatPermissionD>();
        }

        public string UserId { get; set; }
        public string DepId { get; set; }
        public string ProjectId { get; set; }

        public virtual ICollection<TndrTitemsCatPermissionD> TndrTitemsCatPermissionD { get; set; }
    }
}
