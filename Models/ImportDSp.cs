using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ImportDSp
    {
        public string TableName { get; set; }
        public string FormId { get; set; }
        public string ParamterName { get; set; }
        public string FieldName { get; set; }
    }
}
