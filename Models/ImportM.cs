using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class ImportM
    {
        public string TableName { get; set; }
        public string FormId { get; set; }
        public string StoredProcedures { get; set; }
    }
}
