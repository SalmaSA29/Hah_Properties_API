using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecQualifications
    {
        public int QualificationsId { get; set; }
        public int VacancyId { get; set; }
        public string QualificationsName { get; set; }
    }
}
