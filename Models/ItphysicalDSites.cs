using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItphysicalDSites
    {
        public int PhysicalSites { get; set; }
        public int ProjectId { get; set; }
        public int CategoryId { get; set; }
        public int TypesId { get; set; }
        public string BarCode { get; set; }
        public string Isps { get; set; }
        public int? Qty { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNo { get; set; }
        public string Size { get; set; }
        public string Processor { get; set; }
        public string Ram { get; set; }
        public string Hdd { get; set; }
        public DateTime? RecivedDate { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
