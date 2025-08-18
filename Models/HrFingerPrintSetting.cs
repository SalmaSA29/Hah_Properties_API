using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrFingerPrintSetting
    {
        public int Id { get; set; }
        public int? FgrpId { get; set; }
        public string EffectNameAr { get; set; }
        public string EffectNameEn { get; set; }
        public string EffectTime { get; set; }
        public string EffectValue { get; set; }
        public string EffectShortcut { get; set; }
    }
}
