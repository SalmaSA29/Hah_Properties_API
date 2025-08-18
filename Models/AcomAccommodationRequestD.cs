using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class AcomAccommodationRequestD
    {
        public int RecordId { get; set; }
        public string EmployeeNo { get; set; }
        public int RequestNo { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string Status { get; set; }
    }
}
