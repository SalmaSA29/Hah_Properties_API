using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprSupermissionWp
    {
        public string UserId { get; set; }
        public string WorkPackageId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public string Descrp { get; set; }
    }
}
