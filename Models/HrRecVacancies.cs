using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecVacancies
    {
        public int VacancyId { get; set; }
        public string VacancyName { get; set; }
        public int MajorId { get; set; }
        public string YearsExperirence { get; set; }
        public string ProjectsExperience { get; set; }
        public string ReportingLine { get; set; }
    }
}
