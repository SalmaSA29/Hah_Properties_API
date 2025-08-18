using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Permissions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GuardName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
