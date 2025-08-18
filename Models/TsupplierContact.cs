using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TsupplierContact
    {
        public string SupplierId { get; set; }
        public int RecordId { get; set; }
        public bool? Main { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Mobile3 { get; set; }
        public string Email { get; set; }
        public string Idnum { get; set; }
        public string Notes { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual Tsupplier Supplier { get; set; }
    }
}
