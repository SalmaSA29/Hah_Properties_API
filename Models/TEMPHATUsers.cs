using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TEMPHATUsers
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserHRCode { get; set; }
        public string UserPassword { get; set; }
        public DateTime? InDate { get; set; }
        public int? InUser { get; set; }
    }
}
