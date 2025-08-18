using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TequipementRecommendedItemD
    {
        public string EquipementId { get; set; }
        public string ItemId { get; set; }
        public string Comments { get; set; }

        public virtual Tequipement Equipement { get; set; }
    }
}
