using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ShowColumn
    {
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public bool Rul { get; set; }
        public string Type { get; set; }
    }
}
