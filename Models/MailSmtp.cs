using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MailSmtp
    {
        public string Smtp { get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
