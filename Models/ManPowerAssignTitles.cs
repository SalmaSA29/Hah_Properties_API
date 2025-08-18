using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ManPowerAssignTitles
    {
        public int AsId { get; set; }
        public int ProjectId { get; set; }
        public int? SapId { get; set; }
        public DateTime? AsStartDate { get; set; }
        public DateTime? AsEndDate { get; set; }
        public int? HeadCount { get; set; }
        public string AsInUser { get; set; }
        public DateTime? AsInDate { get; set; }
        public string AsUpUser { get; set; }
        public DateTime? AsUpDate { get; set; }
    }
}
