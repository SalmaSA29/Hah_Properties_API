using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CoplegalDoccategory
    {
        public int DocCatId { get; set; }
        public int? CompId { get; set; }
        public string Name { get; set; }
        public string Inuser { get; set; }
        public DateTime? InDate { get; set; }
        public string Upuser { get; set; }
        public DateTime? Updateuser { get; set; }
    }
}
