using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprPlanLongLeadM
    {
        public TprPlanLongLeadM()
        {
            TprPlanLongLeadD = new HashSet<TprPlanLongLeadD>();
        }

        public int DocNo { get; set; }
        public string ProjectId { get; set; }
        public string WorkPackageId { get; set; }
        public string Descrp { get; set; }

        public virtual ICollection<TprPlanLongLeadD> TprPlanLongLeadD { get; set; }
    }
}
