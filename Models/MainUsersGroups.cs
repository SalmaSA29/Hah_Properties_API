using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MainUsersGroups
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupPhoto { get; set; }
        public DateTime GroupInDate { get; set; }
        public int GroupInUser { get; set; }
        public DateTime? GroupUpDate { get; set; }
        public int? GroupUpUser { get; set; }
    }
}
