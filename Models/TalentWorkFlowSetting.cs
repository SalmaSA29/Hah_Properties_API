using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TalentWorkFlowSetting
    {
        public int Id { get; set; }
        public int? EntryId { get; set; }
        public int? DepId { get; set; }
        public int? ProTypId { get; set; }
        public int? ScopeId { get; set; }
        public string UserHrcode { get; set; }
    }
}
