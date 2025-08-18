using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ContractForms
    {
        public string FormId { get; set; }

        public virtual CForm Form { get; set; }
    }
}
