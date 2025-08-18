using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagApiModelHasPermissions
    {
        public int PermissionId { get; set; }
        public string ModelType { get; set; }
        public long ModelId { get; set; }
    }
}
