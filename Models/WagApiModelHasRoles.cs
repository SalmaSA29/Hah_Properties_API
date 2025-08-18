using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagApiModelHasRoles
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string ModelType { get; set; }
        public long ModelId { get; set; }
    }
}
