using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Blocks
    {
        public int Id { get; set; }
        public string IdNumber { get; set; }
        public int BlockFrom { get; set; }
        public int BlockTo { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
