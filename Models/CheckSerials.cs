using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CheckSerials
    {
        public int ChNo { get; set; }
        public int? BankId { get; set; }
        public string CheckNo { get; set; }
        public bool? IsUsed { get; set; }
    }
}
