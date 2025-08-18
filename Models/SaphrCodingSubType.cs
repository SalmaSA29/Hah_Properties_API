using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SaphrCodingSubType
    {
        public int SubTypeId { get; set; }
        public int? ParentTypeId { get; set; }
        public string SubTypeName { get; set; }

        public virtual SaphrCodingType ParentType { get; set; }
    }
}
