using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TalentLogSearch
    {
        public int LogId { get; set; }
        public string LogSearchName { get; set; }
        public int? TagId { get; set; }
        public string UserHrcode { get; set; }
        public DateTime? LogDate { get; set; }
    }
}
