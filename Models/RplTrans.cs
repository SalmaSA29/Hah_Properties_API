using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class RplTrans
    {
        public int Serial { get; set; }
        public string TableName { get; set; }
        public string TableMasterName { get; set; }
        public string SutableName { get; set; }
    }
}
