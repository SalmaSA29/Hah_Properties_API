using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagApiProjectsUsers
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
