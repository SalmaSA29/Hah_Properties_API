using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class AttCheckinout
    {
        public string UserId { get; set; }
        public DateTime Checktime { get; set; }
        public string Checktype { get; set; }
        public string Verifycode { get; set; }
        public string Sensorid { get; set; }
        public string Memoinfo { get; set; }
        public string WorkCode { get; set; }
        public string Sn { get; set; }
        public int? UserExtFmt { get; set; }
        public string UserHrCode { get; set; }
    }
}
