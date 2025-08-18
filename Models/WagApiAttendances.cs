using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagApiAttendances
    {
        public int Id { get; set; }
        public string IdNumber { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan? ArrivalTime { get; set; }
        public TimeSpan? LeaveTime { get; set; }
        public byte? Follow { get; set; }
        public TimeSpan? FollowTime { get; set; }
        public string FollowComment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
