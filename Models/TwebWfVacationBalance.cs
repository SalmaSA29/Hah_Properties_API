using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebWfVacationBalance
    {
        public string UserHrCode { get; set; }
        public int? VacationBalance { get; set; }
        public int? DaysTaken { get; set; }
        public int? DaysLeft { get; set; }
        public int? BalanceFromLastYear { get; set; }
        public int? OldBalanceFromLastYear { get; set; }
    }
}
