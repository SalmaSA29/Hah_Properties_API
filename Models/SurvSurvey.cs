using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SurvSurvey
    {
        public int SurveyId { get; set; }
        public bool? Active { get; set; }
        public string Year { get; set; }
        public string Quarter { get; set; }
        public string Description { get; set; }
    }
}
