using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ImportDKeys
    {
        public int RecordId { get; set; }
        public string TableName { get; set; }
        public string TableIns { get; set; }
        public string FieldIns { get; set; }
        public string TableSource { get; set; }
        public string FieldSource { get; set; }
        public bool? UseInCondition { get; set; }
    }
}
