using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagApiAreas
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Active { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
