using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SettingGeneral
    {
        public string DbId { get; set; }
        public int Serl { get; set; }
        public int? Fraction { get; set; }
        public int? FractionCurr { get; set; }
        public int? FractionQty { get; set; }
        public bool? NewPublish { get; set; }
        public bool? UseWindowsAuthentication { get; set; }
    }
}
