using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagCondition
    {
        public int Id { get; set; }
        public double? CondProductive { get; set; }
        public double? CondTeamProductive { get; set; }
        public double? CondNonProductive { get; set; }
        public double? CondTeamNonProductive { get; set; }
    }
}
