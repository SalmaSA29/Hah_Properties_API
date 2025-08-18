using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprojectCurrency
    {
        public string CurrencyId { get; set; }
        public string ProjectId { get; set; }
        public string Comments { get; set; }

        public virtual Tproject Project { get; set; }
    }
}
