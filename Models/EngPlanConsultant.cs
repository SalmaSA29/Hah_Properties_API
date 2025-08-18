using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanConsultant
    {
        public int ConsultantId { get; set; }
        public string Consultantname { get; set; }
        public string ConsultantInUser { get; set; }
        public DateTime? ConsultantInDate { get; set; }
        public string ConsultantUpUser { get; set; }
        public DateTime? ConsultantUpDate { get; set; }
        public string ConsultantDesc { get; set; }
    }
}
