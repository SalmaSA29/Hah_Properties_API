using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.ViewModel
{
    public class VM_AccountToken
    {
        public string UserHRCode { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public DateTime? Expiration { get; set; }
    }
}
