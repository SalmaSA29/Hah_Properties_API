using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ChatUser
    {
        public int ChId { get; set; }
        public string ChCode { get; set; }
        public string ChTitle { get; set; }
        public string SendUser { get; set; }
        public string ResvUser { get; set; }
        public string UserMessage { get; set; }
    }
}
