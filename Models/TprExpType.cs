using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprExpType
    {
        public string ExpType { get; set; }
        public string ExpDescription { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }
        public bool? Cost { get; set; }
        public bool? StaffSalaries { get; set; }
        public bool? LaborSalaries { get; set; }
        public bool? EquipmentDepreciation { get; set; }
        public bool? EquipmentRent { get; set; }
        public bool? StaffBudget { get; set; }
        public bool? LaborBudget { get; set; }
        public bool? ScaffoldingRent { get; set; }
        public bool? ScaffoldingDepreciation { get; set; }
        public bool? InDirect { get; set; }
        public string ExpTypeCat { get; set; }
        public string CostId { get; set; }
    }
}
