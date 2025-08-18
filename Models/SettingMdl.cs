using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SettingMdl
    {
        public SettingMdl()
        {
            SettingMdlD = new HashSet<SettingMdlD>();
        }

        public string MdlName { get; set; }
        public bool Rul { get; set; }
        public bool? MdlGeneral { get; set; }
        public bool? MdlAssets { get; set; }
        public bool? MdlNotes { get; set; }
        public bool? MdlStock { get; set; }
        public bool? MdlPurchase { get; set; }
        public bool? MdlSales { get; set; }
        public bool? MdlProduction { get; set; }
        public bool? MdlImport { get; set; }
        public bool? MdlCont { get; set; }
        public bool? MdlMk { get; set; }
        public bool? MdlOpWithOth { get; set; }

        public virtual ICollection<SettingMdlD> SettingMdlD { get; set; }
    }
}
