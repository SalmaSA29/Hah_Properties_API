using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TrkPurchasingPropNewItms
    {
        public int PropItmsId { get; set; }
        public int? ProjectId { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public string EmailTo { get; set; }
        public string Comment { get; set; }
        public string Mobile { get; set; }
        public string Img { get; set; }
    }
}
