using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TsupplierWorkPackage
    {
        public string SupplierId { get; set; }
        public string WorkPackageId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public string Comments { get; set; }

        public virtual Tsupplier Supplier { get; set; }
    }
}
