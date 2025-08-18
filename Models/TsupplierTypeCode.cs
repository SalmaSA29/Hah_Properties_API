using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TsupplierTypeCode
    {
        public TsupplierTypeCode()
        {
            TsupplierTypeCodeD = new HashSet<TsupplierTypeCodeD>();
        }

        public string SupplierTypeCode { get; set; }
        public string SupplierTypeName { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual ICollection<TsupplierTypeCodeD> TsupplierTypeCodeD { get; set; }
    }
}
