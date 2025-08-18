using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrTecCriteriaD
    {
        public string HrCriteriaId { get; set; }
        public int HrTechnicalId { get; set; }
        public string Grade { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
