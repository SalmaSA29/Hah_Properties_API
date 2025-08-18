using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecJobDescription
    {
        public int JobDescriptionId { get; set; }
        public int? VacancyId { get; set; }
        public string JobDescriptionName { get; set; }
    }
}
