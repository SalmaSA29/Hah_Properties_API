using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class AttSetting
    {
        public int SettingId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? ReadingMethod { get; set; }
        public int? ReadingIntimeValue { get; set; }
        public int? ReadingOuTimeValue { get; set; }
        public string AccessDatabasePath { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? LateMinutes { get; set; }
        public int? EarlyMinutes { get; set; }
        public string Comments { get; set; }
    }
}
