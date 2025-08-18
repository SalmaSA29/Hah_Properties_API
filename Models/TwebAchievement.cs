using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebAchievement
    {
        public int AchievementId { get; set; }
        public string AchievementTitle { get; set; }
        public string AchievementDescription { get; set; }
        public DateTime? Date { get; set; }
        public string FUserId { get; set; }
        public bool? Hrapprove { get; set; }
        public bool? ManagerApprove { get; set; }
    }
}
