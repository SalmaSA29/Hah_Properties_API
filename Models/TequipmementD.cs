using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TequipmementD
    {
        public string EquipementId { get; set; }
        public int RecordId { get; set; }
        public DateTime Date { get; set; }
        public string ProjectIdFrom { get; set; }
        public string ProjectIdTo { get; set; }
        public bool? WithDriver { get; set; }
        public string DriverIdFrom { get; set; }
        public string DriverIdTo { get; set; }
        public string SiteNote { get; set; }
        public string RecipientNote { get; set; }

        public virtual Tequipement Equipement { get; set; }
    }
}
