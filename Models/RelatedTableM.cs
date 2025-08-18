using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RelatedTableM
    {
        public int RelatedId { get; set; }
        public string TableName { get; set; }
        public string RelatedTable { get; set; }
        public string Caption { get; set; }
        public string CaptionEn { get; set; }
        public bool? IsMaster { get; set; }
    }
}
