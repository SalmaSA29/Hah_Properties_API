using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanItems
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public string ItemInUser { get; set; }
        public DateTime? ItemInDate { get; set; }
        public string ItemUpUser { get; set; }
        public DateTime? ItemUpDate { get; set; }
    }
}
