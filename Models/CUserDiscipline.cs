using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CUserDiscipline
    {
        public string UserId { get; set; }
        public string DisciplineCode { get; set; }
        public string Comments { get; set; }

        public virtual CUser User { get; set; }
    }
}
