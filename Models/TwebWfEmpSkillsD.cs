using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebWfEmpSkillsD
    {
        public string UserHrCode { get; set; }
        public int RecordId { get; set; }
        public string SkillsName { get; set; }
        public int? LangSkillLevelId { get; set; }
        public string Description { get; set; }
    }
}
