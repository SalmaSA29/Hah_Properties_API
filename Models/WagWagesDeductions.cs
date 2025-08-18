using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagWagesDeductions
    {
        public int DedId { get; set; }
        public DateTime? Date { get; set; }
        public string EmployeeNo { get; set; }
        public double? Deductions { get; set; }
        public string Remarks { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
    }
}
