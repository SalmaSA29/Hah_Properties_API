using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanStepsUsers
    {
        public int Serial { get; set; }
        public int StepDescriptionNo { get; set; }
        public int StepNo { get; set; }
        public int UserId { get; set; }
        public string Descrp { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
    }
}
