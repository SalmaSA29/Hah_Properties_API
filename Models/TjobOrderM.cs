using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TjobOrderM
    {
        public TjobOrderM()
        {
            TjobOrderD = new HashSet<TjobOrderD>();
            TwsComplainsD = new HashSet<TwsComplainsD>();
            TwsExternalProcess = new HashSet<TwsExternalProcess>();
            TwsInspectionsD = new HashSet<TwsInspectionsD>();
            TwsPrOrderM = new HashSet<TwsPrOrderM>();
            TwsPurchaseM = new HashSet<TwsPurchaseM>();
            TwsSalesM = new HashSet<TwsSalesM>();
            TwsTechnicanD = new HashSet<TwsTechnicanD>();
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
        public bool? BadUsage { get; set; }
        public int? JobOrderType { get; set; }
        public int? InternalOrExternal { get; set; }
        public bool? MajorRepair { get; set; }
        public string Comments { get; set; }

        public virtual Tequipement Equipement { get; set; }
        public virtual Tproject Project { get; set; }
        public virtual ICollection<TjobOrderD> TjobOrderD { get; set; }
        public virtual ICollection<TwsComplainsD> TwsComplainsD { get; set; }
        public virtual ICollection<TwsExternalProcess> TwsExternalProcess { get; set; }
        public virtual ICollection<TwsInspectionsD> TwsInspectionsD { get; set; }
        public virtual ICollection<TwsPrOrderM> TwsPrOrderM { get; set; }
        public virtual ICollection<TwsPurchaseM> TwsPurchaseM { get; set; }
        public virtual ICollection<TwsSalesM> TwsSalesM { get; set; }
        public virtual ICollection<TwsTechnicanD> TwsTechnicanD { get; set; }
    }
}
