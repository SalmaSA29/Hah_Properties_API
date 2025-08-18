using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanUnit
    {
        public int UnId { get; set; }
        public string UnName { get; set; }
        public int? UnNoOfColumn { get; set; }
        public string UnDesc { get; set; }
        public string UnInUser { get; set; }
        public DateTime? UnInDate { get; set; }
        public string UnUpUser { get; set; }
        public DateTime? UnUpDate { get; set; }
    }
}
