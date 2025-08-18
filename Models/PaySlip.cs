using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class PaySlip
    {
        public int PaySlipId { get; set; }
        public string UserHrcode { get; set; }
        public string Name { get; set; }
        public int? ProjectId { get; set; }
        public string SignatureFile { get; set; }
        public string January { get; set; }
        public string February { get; set; }
        public string March { get; set; }
        public string April { get; set; }
        public string May { get; set; }
        public string June { get; set; }
        public string July { get; set; }
        public string August { get; set; }
        public string September { get; set; }
        public string October { get; set; }
        public string November { get; set; }
        public string December { get; set; }
        public bool? Active { get; set; }
        public string Comment { get; set; }
    }
}
