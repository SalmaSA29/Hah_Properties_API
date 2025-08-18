using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SaphrCodingType
    {
        public SaphrCodingType()
        {
            SaphrCodingSubType = new HashSet<SaphrCodingSubType>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<SaphrCodingSubType> SaphrCodingSubType { get; set; }
    }
}
