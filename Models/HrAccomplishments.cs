using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrAccomplishments
    {
        public string UserHrCode { get; set; }
        public int AcomId { get; set; }
        public int RecordId { get; set; }
        public string Name { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string Location { get; set; }
        public string Level { get; set; }
        public int? LanguageId { get; set; }
    }
}
