using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class AcomHousing
    {
        public int RequestNo { get; set; }
        public string EmployeeNo { get; set; }
        public string AccommodationId { get; set; }
        public DateTime? RequiredDate { get; set; }
        public int? AcomHousingTypeId { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
