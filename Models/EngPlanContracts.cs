using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanContracts
    {
        public int ContId { get; set; }
        public string ContName { get; set; }
        public string ContDesc { get; set; }
        public string ContInUser { get; set; }
        public DateTime? ContInDate { get; set; }
        public string ContUpUser { get; set; }
        public DateTime? ContUpDate { get; set; }
    }
}
