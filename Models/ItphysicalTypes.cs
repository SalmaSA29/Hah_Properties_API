using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItphysicalTypes
    {
        public int TypesId { get; set; }
        public int CategoryId { get; set; }
        public string TypesName { get; set; }

        public virtual ItphysicalCategories Category { get; set; }
    }
}
