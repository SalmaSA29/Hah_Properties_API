using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Menu
    {
        public Menu()
        {
            CForm = new HashSet<CForm>();
        }

        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuNameEn { get; set; }
        public string ParentId { get; set; }
        public bool? DontUseInReport { get; set; }

        public virtual ICollection<CForm> CForm { get; set; }
    }
}
