using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ScaffoldingNotesD
    {
        public string ProjectId { get; set; }
        public DateTime? RequiredFrom { get; set; }
        public string Comments { get; set; }

        public virtual ScaffoldingNotesM Project { get; set; }
    }
}
