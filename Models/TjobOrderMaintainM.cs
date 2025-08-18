using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TjobOrderMaintainM
    {
        public TjobOrderMaintainM()
        {
            TjobOrderMaintainD = new HashSet<TjobOrderMaintainD>();
            TwsComplainsMaintainD = new HashSet<TwsComplainsMaintainD>();
            TwsExternalProcessMaintain = new HashSet<TwsExternalProcessMaintain>();
            TwsInspectionsMaintainD = new HashSet<TwsInspectionsMaintainD>();
            TwsTechnicanMaintainD = new HashSet<TwsTechnicanMaintainD>();
        }

        public string DocNo { get; set; }
        public string EquipementId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string OpStatus { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public string ProjectId { get; set; }
        public double? ValParts { get; set; }
        public double? ValMaterials { get; set; }
        public double? ValExternal { get; set; }
        public double? ValTools { get; set; }
        public double? ValInternal { get; set; }
        public double? ValTotal { get; set; }
        public string Transferred { get; set; }
        public string Inspector { get; set; }
        public string Authorised { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<TjobOrderMaintainD> TjobOrderMaintainD { get; set; }
        public virtual ICollection<TwsComplainsMaintainD> TwsComplainsMaintainD { get; set; }
        public virtual ICollection<TwsExternalProcessMaintain> TwsExternalProcessMaintain { get; set; }
        public virtual ICollection<TwsInspectionsMaintainD> TwsInspectionsMaintainD { get; set; }
        public virtual ICollection<TwsTechnicanMaintainD> TwsTechnicanMaintainD { get; set; }
    }
}
