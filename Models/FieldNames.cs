using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class FieldNames
    {
        public string TableName { get; set; }
        public string EngName { get; set; }
        public string ArName { get; set; }
        public string EnName { get; set; }
        public byte? FractionType { get; set; }
        public byte? CurrencyType { get; set; }
    }
}
