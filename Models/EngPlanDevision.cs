using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanDevision
    {
        public int DevId { get; set; }
        public string DevCode { get; set; }
        public string DevName { get; set; }
        public string DevInUser { get; set; }
        public DateTime? DevInDate { get; set; }
        public string DevUpUser { get; set; }
        public DateTime? DevUpDate { get; set; }
    }
}
