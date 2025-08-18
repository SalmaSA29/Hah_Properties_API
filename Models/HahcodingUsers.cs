using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HahcodingUsers
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool? IsAdmin { get; set; }
        public string UserAdded { get; set; }
        public DateTime? DateCreation { get; set; }
        public string UserModified { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
