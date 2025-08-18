using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CheckType
    {
        public int TypeId { get; set; }
        public int? PaymentTypeId { get; set; }
        public string TypeName { get; set; }
    }
}
