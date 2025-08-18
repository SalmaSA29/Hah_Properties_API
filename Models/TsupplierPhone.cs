using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TsupplierPhone
    {
        public string SupplierId { get; set; }
        public int RecordId { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneType { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual Tsupplier Supplier { get; set; }
    }
}
