using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkProcuremantComments
    {
        public int ComId { get; set; }
        public int ProcurementId { get; set; }
        public int? Serial { get; set; }
        public DateTime? ComDate { get; set; }
        public string Comments { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }

        public virtual TrkProcurement Procurement { get; set; }
    }
}
