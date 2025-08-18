using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScaffoldingNotesM
    {
        public string ProjectId { get; set; }
        public string Comments { get; set; }

        public virtual ScaffoldingNotesD ScaffoldingNotesD { get; set; }
    }
}
