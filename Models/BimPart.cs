using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class BimPart
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public int? FloorId { get; set; }
        public int? ProjectId { get; set; }
        public string InUser { get; set; }
        public DateTime? PartDate { get; set; }
    }
}
