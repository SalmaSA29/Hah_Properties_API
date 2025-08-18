using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CallCenterM
    {
        public int CallNo { get; set; }
        public DateTime Date { get; set; }
        public string CustId { get; set; }
        public string Requirements { get; set; }
        public bool Done { get; set; }
        public string DbId { get; set; }
        public int? MessageId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
