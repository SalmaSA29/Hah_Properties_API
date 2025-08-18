using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SP_HRStatistics
    {
        public int ID { get; set; }
        public string ServiceName { get; set; }
        public string Balance { get; set; }
        public string Consumed { get; set; }
        public string Remaining { get; set; }
    }
}
