using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CoplegalFolder
    {
        public int FoulderId { get; set; }
        public string Name { get; set; }
        public int? DocCatId { get; set; }
        public string Inuser { get; set; }
        public DateTime? InDate { get; set; }
        public string Upuser { get; set; }
        public DateTime? Updateuser { get; set; }
    }
}
