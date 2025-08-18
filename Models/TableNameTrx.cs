using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TableNameTrx
    {
        public int Serl { get; set; }
        public string TableName { get; set; }
        public bool NotClearInClosing { get; set; }
        public string Condition { get; set; }
    }
}
