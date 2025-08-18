using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class EngPlanQs
    {
        public int QsId { get; set; }
        public int? ContId { get; set; }
        public int? ItemId { get; set; }
        public int? ProjectId { get; set; }
        public int? DevId { get; set; }
        public int? SubContractorId { get; set; }
        public int? DiscId { get; set; }
        public int? UnId { get; set; }
        public int? BuId { get; set; }
        public int? FlId { get; set; }
        public int? ZoId { get; set; }
        public int? RoId { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
