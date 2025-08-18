using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanSubContractor
    {
        public int SubContractorId { get; set; }
        public string SubContractorName { get; set; }
        public string SubContractorAddress { get; set; }
        public string SubContractorEmail { get; set; }
        public string SubContractorPhone { get; set; }
        public string SubContractorInUser { get; set; }
        public DateTime? SubContractorInDate { get; set; }
        public string SubContractorUpUser { get; set; }
        public DateTime? SubContractorUpDate { get; set; }
    }
}
