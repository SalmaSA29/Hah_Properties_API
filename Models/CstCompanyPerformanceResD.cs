using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstCompanyPerformanceResD
    {
        public string ProjectId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public double? StaffSalaries { get; set; }
        public double? LaborSalaries { get; set; }
        public double? EquipmentDepreciation { get; set; }
        public double? EquipmentRent { get; set; }
        public double? StaffBudget { get; set; }
        public double? LaborBudget { get; set; }
        public double? ScaffoldingRent { get; set; }
        public double? ScaffoldingDepreciation { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual CstCompanyPerformanceM CstCompanyPerformanceM { get; set; }
    }
}
