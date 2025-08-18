using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwsInspection
    {
        public TwsInspection()
        {
            TwsInspectionsD = new HashSet<TwsInspectionsD>();
            TwsInspectionsMaintainD = new HashSet<TwsInspectionsMaintainD>();
        }

        public string InspectionId { get; set; }
        public string InspectionName { get; set; }

        public virtual ICollection<TwsInspectionsD> TwsInspectionsD { get; set; }
        public virtual ICollection<TwsInspectionsMaintainD> TwsInspectionsMaintainD { get; set; }
    }
}
