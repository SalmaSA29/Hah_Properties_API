using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RelatedTableD
    {
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string SourceTableName { get; set; }
        public string DisplayFieldName { get; set; }
        public string SourceKeyFieldName { get; set; }
    }
}
