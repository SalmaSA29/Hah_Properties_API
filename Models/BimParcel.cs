using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class BimParcel
    {
        public int ParcelId { get; set; }
        public string ParcelName { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
    }
}
