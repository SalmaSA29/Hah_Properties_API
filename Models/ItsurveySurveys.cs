using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItsurveySurveys
    {
        public int SurveyId { get; set; }
        public string SurveyName { get; set; }
        public bool? IsActive { get; set; }
    }
}
