using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ItphysicalCategories
    {
        public ItphysicalCategories()
        {
            ItphysicalTypes = new HashSet<ItphysicalTypes>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<ItphysicalTypes> ItphysicalTypes { get; set; }
    }
}
