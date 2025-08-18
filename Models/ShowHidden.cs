using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ShowHidden
    {
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string ArName { get; set; }
        public string EnName { get; set; }
        public string ShowAfter { get; set; }
    }
}
