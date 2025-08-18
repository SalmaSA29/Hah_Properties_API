using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class QualityIsoDepartment
    {
        public int DepId { get; set; }
        public string DepName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
