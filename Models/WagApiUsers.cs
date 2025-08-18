using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagApiUsers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string NewPassword { get; set; }
        public bool Active { get; set; }
        public bool? IsCoordinator { get; set; }
        public string In_User { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
