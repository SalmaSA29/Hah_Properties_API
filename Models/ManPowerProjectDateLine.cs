using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ManPowerProjectDateLine
    {
        public int DlId { get; set; }
        public int ProjectId { get; set; }
        public DateTime? DlMonth { get; set; }
        public double? DlBudgetAmount { get; set; }
        public string DlInUser { get; set; }
        public DateTime? DlInDate { get; set; }
        public string DlUpUser { get; set; }
        public DateTime? DlUpDate { get; set; }
    }
}
